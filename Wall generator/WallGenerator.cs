using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Wall_generator {
    public partial class WallGenerator : Form {
        const float FOOT_TO_METER = 0.3048f;
        Bitmap svgView;
        List<PointFloat> vertexList = new List<PointFloat>();
        List<Tuple<int, int>> edgeList = new List<Tuple<int, int>>();
        XDocument svgXMLDoc;

        public WallGenerator() {
            InitializeComponent();
        }

        private void curveToCubic(float x1, float y1, float x2, float y2, float x, float y) {
            float x0 = vertexList.Last().x;
            float y0 = vertexList.Last().y;
            float distance = (x - x0) * (x - x0) + (y - y0) * (y - y0);

            float step = (float) (10 / Math.Sqrt(distance));

            for (float t = step; t < 1; t += step) {
                float newX = (1 - t) * (1 - t) * (1 - t) * x0 + 3 * (1 - t) * (1 - t) * t * x1 + 3 * (1 - t) * t * t * x2 + t * t * t * x;
                float newY = (1 - t) * (1 - t) * (1 - t) * y0 + 3 * (1 - t) * (1 - t) * t * y1 + 3 * (1 - t) * t * t * y2 + t * t * t * y;
                lineTo(newX, newY);
            }
            lineTo(x, y);
        }

        private void curveToQuad(float x1, float y1, float x, float y) {
            float x0 = vertexList.Last().x;
            float y0 = vertexList.Last().y;
            float distance = (x - x0) * (x - x0) + (y - y0) * (y - y0);

            float step = (float)(10 / Math.Sqrt(distance));

            for (float t = step; t < 1; t += step) {
                float newX = (1 - t) * (1 - t) * x0 + (1 - t) * t * x1 + t * t * x;
                float newY = (1 - t) * (1 - t) * y0 + (1 - t) * t * y1 + t * t * y;
                lineTo(newX, newY);
            }
            lineTo(x, y);
        }

        private void lineTo(float x, float y) {
            int fromIndex = vertexList.Count - 1;
            int toIndex = vertexList.Count;
            bool duplicate = false;
            for (int i = 0; i < vertexList.Count; i++) {
                //if (vertexList[i].x - x == x && vertexList[i].y == y) {
                if (Math.Abs(vertexList[i].x - x) <= .1 && Math.Abs(vertexList[i].y - y) <= .1) {
                    duplicate = true;
                    toIndex = i;
                    break;
                }
            }
            if (!duplicate) {
                vertexList.Add(new PointFloat(x, y));
            }
            edgeList.Add(new Tuple<int, int>(fromIndex, toIndex));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void openSVGToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    svgXMLDoc = XDocument.Load(openFileDialog1.FileName);
                    xmlToVertex();
                    renderToView();
                }
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        private void renderToView() {
            Graphics g = Graphics.FromImage(svgView);
            Pen pen = new Pen(Color.Black);
            pen.Color = Color.Red;
            foreach (Tuple<Int32, Int32> edge in edgeList) {
                PointFloat point1 = vertexList[edge.Item1];
                PointFloat point2 = vertexList[edge.Item2];
                g.DrawLine(pen, point1.x, point1.y, point2.x, point2.y);
            }
            pen.Color = Color.Blue;
            foreach (PointFloat point in vertexList) {
                g.FillEllipse(pen.Brush, point.x - 2, point.y - 2, 4, 4);
            }
        }

        private void xmlToVertex() {
            string token = "";
            try {
                var svgElement = svgXMLDoc.Elements().Where(s => s.Name.LocalName == "svg").FirstOrDefault();
                int width = (int)float.Parse(Regex.Replace(svgElement.Attribute("width").Value, "[^0-9\\-\\.]", ""));
                int height = (int)float.Parse(Regex.Replace(svgElement.Attribute("height").Value, "[^0-9\\-\\.]", ""));
                svgView = new Bitmap(width, height);
                pictureBox1.Image = svgView;
                System.Diagnostics.Debug.WriteLine(width + "x" + height);
                float translateX = 0, translateY = 0, scaleX = 1, scaleY = 1;
                var paths = svgElement.Descendants().Where(s => s.Name.LocalName == "path");
                vertexList.Clear();
                edgeList.Clear();
                foreach (var path in paths) {
                    if (path.Parent.Name.LocalName == "g") {
                        System.Diagnostics.Debug.WriteLine(path.Parent.Name);
                        string transform = path.Parent.Attribute("transform").Value;
                        Match translateMatch = Regex.Match(transform, "translate[^\\)]+\\)");
                        if (translateMatch != null) {
                            string translate = translateMatch.ToString().Substring("translate(".Length);
                            translate = translate.Substring(0, translate.Length - 1);
                            string[] args = translate.Split(",".ToCharArray());
                            translateX = float.Parse(args[0].Trim());
                            translateY = float.Parse(args[1].Trim());
                        }
                        Match scaleMatch = Regex.Match(transform, "scale[^\\)]+\\)");
                        if (scaleMatch != null) {
                            string scale = scaleMatch.ToString().Substring("scale(".Length);
                            scale = scale.Substring(0, scale.Length - 1);
                            string[] args = scale.Split(",".ToCharArray());
                            scaleX = float.Parse(args[0].Trim());
                            scaleY = float.Parse(args[1].Trim());
                        }
                    }

                    string d = path.Attribute("d").Value.Replace(',', ' ').Replace("\r", "").Replace("\n", "").Replace("\t", " ");
                    d = Regex.Replace(d, "\\s+", " ");
                    Match match;
                    while ((match = Regex.Match(d, "\\d\\-")).Success) {
                        d = d.Substring(0, match.Index + 1) + " " + d.Substring(match.Index + 1);
                    }
                    System.Diagnostics.Debug.WriteLine(d);
                    System.Diagnostics.Debug.WriteLine(translateX + ", " + translateY + " - " + scaleX + ", " + scaleY);
                    float cursorX = 0;
                    float cursorY = 0;
                    token = "";
                    string previousToken = "";

                    PointFloat lastStartPoint = new PointFloat();
                    PointFloat lastEndPoint = new PointFloat();
                    int loopStart = vertexList.Count;
                    while (d.Length > 0) {
                        //System.Diagnostics.Debug.WriteLine(d);
                        readNextToken(ref d, "\\S");
                        if (Regex.IsMatch(d.Substring(0, 1), "[^0-9\\-\\.]")) {
                            token = d.Substring(0, 1);
                            d = d.Substring(1);
                        } else {
                            token = previousToken;
                        }
                        switch (token) {
                            case "M":
                                cursorX = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                readNextToken(ref d, "[^\\s]");
                                cursorY = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                vertexList.Add(new PointFloat(cursorX, cursorY));
                                break;
                            case "m":
                                cursorX += float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                readNextToken(ref d, "[^\\s]");
                                cursorY += float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                vertexList.Add(new PointFloat(cursorX, cursorY));
                                break;
                            case "L":
                            case "l": {
                                    float x = 0, y = 0;
                                    if (token == "L") {
                                        x = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                    } else {
                                        x = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = cursorY + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                    }
                                    cursorX = x;
                                    cursorY = y;
                                    lineTo(cursorX, cursorY);
                                    break;
                                }
                            case "H":
                            case "h": {
                                    float x = 0;
                                    if (token == "H") {
                                        x = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleX + translateX;
                                    } else {
                                        x = cursorX + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleX;
                                    }
                                    cursorX = x;
                                    lineTo(cursorX, cursorY);
                                    break;
                                }
                            case "V":
                            case "v": {
                                    float y = 0;
                                    if (token == "V") {
                                        y = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                    } else {
                                        y = cursorY + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                    }
                                    cursorY = y;
                                    lineTo(cursorX, cursorY);
                                    break;
                                }
                            case "C":
                            case "c": {
                                    float x = 0, y = 0, x1 = 0, y1 = 0, x2 = 0, y2 = 0;
                                    if (token == "C") {
                                        x1 = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y1 = float.Parse(readNextToken(ref d, "\\s")) * scaleY + translateY;
                                        readNextToken(ref d, "[^\\s]");
                                        x2 = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y2 = float.Parse(readNextToken(ref d, "\\s")) * scaleY + translateY;
                                        readNextToken(ref d, "[^\\s]");
                                        x = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                    } else {
                                        x1 = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y1 = cursorY + float.Parse(readNextToken(ref d, "\\s")) * scaleY;
                                        readNextToken(ref d, "[^\\s]");
                                        x2 = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y2 = cursorY + float.Parse(readNextToken(ref d, "\\s")) * scaleY;
                                        readNextToken(ref d, "[^\\s]");
                                        x = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = cursorY + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                    }
                                    cursorX = x;
                                    cursorY = y;
                                    curveToCubic(x1, y1, x2, y2, x, y);
                                    lastStartPoint.x = x1;
                                    lastStartPoint.y = y1;
                                    lastEndPoint.x = x2;
                                    lastEndPoint.y = y2;
                                    break;
                                }
                            case "Q":
                            case "q": {
                                    float x = 0, y = 0, x1 = 0, y1 = 0;
                                    if (token == "Q") {
                                        x1 = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y1 = float.Parse(readNextToken(ref d, "\\s")) * scaleY + translateY;
                                        readNextToken(ref d, "[^\\s]");
                                        x = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                    } else {
                                        x1 = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y1 = cursorY + float.Parse(readNextToken(ref d, "\\s")) * scaleY;
                                        readNextToken(ref d, "[^\\s]");
                                        x = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = cursorY + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                    }
                                    cursorX = x;
                                    cursorY = y;
                                    lastStartPoint.x = x1;
                                    lastStartPoint.y = y1;
                                    curveToQuad(x1, y1, x, y);
                                    break;
                                }
                            case "S":
                            case "s": {
                                    float x = 0, y = 0, x2 = 0, y2 = 0;
                                    if (token == "S") {
                                        x2 = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y2 = float.Parse(readNextToken(ref d, "\\s")) * scaleY + translateY;
                                        readNextToken(ref d, "[^\\s]");
                                        x = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                    } else {
                                        x2 = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y2 = cursorY + float.Parse(readNextToken(ref d, "\\s")) * scaleY;
                                        readNextToken(ref d, "[^\\s]");
                                        x = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = cursorY + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                    }
                                    cursorX = x;
                                    cursorY = y;
                                    curveToCubic(lastEndPoint.x, lastEndPoint.y, x2, y2, x, y);
                                    lastEndPoint.x = x2;
                                    lastEndPoint.y = y2;
                                    break;
                                }
                            case "T":
                            case "t": {
                                    float x = 0, y = 0;
                                    if (token == "T") {
                                        x = float.Parse(readNextToken(ref d, "\\s")) * scaleX + translateX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY + translateY;
                                    } else {
                                        x = cursorX + float.Parse(readNextToken(ref d, "\\s")) * scaleX;
                                        readNextToken(ref d, "[^\\s]");
                                        y = cursorY + float.Parse(readNextToken(ref d, "[^0-9\\-\\.]")) * scaleY;
                                    }
                                    cursorX = x;
                                    cursorY = y;
                                    curveToCubic(lastStartPoint.x, lastStartPoint.y, lastEndPoint.x, lastEndPoint.y, x, y);
                                    break;
                                }
                            case "z":
                            case "Z":
                                lineTo(vertexList[loopStart].x, vertexList[loopStart].y);
                                loopStart = vertexList.Count;
                                break;
                            default:
                                System.Diagnostics.Debug.WriteLine("doodster");
                                readNextToken(ref d, "[^a-zA-Z]");
                                break;
                        }
                        previousToken = token;
                        //System.Diagnostics.Debug.WriteLine(d);
                    }
                }
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace + "\n" + token);
            }
        }

        private string readNextToken(ref string str, String delimiter) {
            Match match = Regex.Match(str, delimiter);
            int delimiterIndex = Regex.Match(str, delimiter).Index;
            if (!match.Success) {
                delimiterIndex = str.Length;
            }
            String result = str.Substring(0, delimiterIndex);
            str = str.Substring(delimiterIndex);
            //System.Diagnostics.Debug.WriteLine(str + " - " + delimiterIndex);
            return result;
        }

        private void normalize() {
            float min = float.NegativeInfinity;
            float max = float.PositiveInfinity;

            foreach (PointFloat vertex in vertexList) {
                if (vertex.x < min) min = vertex.x;
                if (vertex.x > max) max = vertex.x;
                if (vertex.y < min) min = vertex.y;
                if (vertex.y > max) max = vertex.y;
            }

            foreach (PointFloat vertex in vertexList) {
                vertex.x /= (max = min);
                vertex.y /= (max = min);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void exportToOBJToolStripMenuItem_Click(object sender, EventArgs e) {
            List<int[]> faceList = new List<int[]>();
            List<PointFloat> outputList = new List<PointFloat>();
            Dictionary<int, int> vertexCache = new Dictionary<int, int>();
            float wallHeight = (float) numericUpDown1.Value * FOOT_TO_METER;
            float minX = vertexList[0].x;
            float maxX = vertexList[0].x;

            foreach (PointFloat point in vertexList) {
                outputList.Add(point);
                if (point.x > maxX) maxX = point.x;
                if (point.x < minX) minX = point.x;
            }
            float footPerPixel = (float)numericUpDown2.Value / (maxX - minX);

            foreach (Tuple<int, int> edge in edgeList) {
                int[] newFace = new int[4];
                PointFloat vertex1 = vertexList[edge.Item1];
                PointFloat vertex2 = vertexList[edge.Item2];
                if (vertexCache.ContainsKey(edge.Item2)) {
                    newFace[2] = vertexCache[edge.Item2];
                } else {
                    outputList.Add(new PointFloat(vertex2.x, vertex2.y, wallHeight));
                    newFace[2] = outputList.Count - 1;
                    vertexCache.Add(edge.Item2, newFace[2]);
                }
                if (vertexCache.ContainsKey(edge.Item1)) {
                    newFace[3] = vertexCache[edge.Item1];
                } else {
                    outputList.Add(new PointFloat(vertex1.x, vertex1.y, wallHeight));
                    newFace[3] = outputList.Count - 1;
                    vertexCache.Add(edge.Item1, newFace[3]);
                }

                newFace[0] = edge.Item1 + 1;
                newFace[1] = edge.Item2 + 1;
                newFace[2]++;
                newFace[3]++;

                faceList.Add(newFace);
            }

            String outputString = "o Walls\n";
            foreach (PointFloat vertex in outputList) {
                outputString += "v " + (vertex.x * footPerPixel * FOOT_TO_METER)
                    + " " + vertex.z // z is already in meter.
                    + " " + (vertex.y * footPerPixel * FOOT_TO_METER) + "\n";
            }

            foreach (int[] face in faceList) {
                outputString += "f";
                foreach (int vertex in face) outputString += " " + vertex;
                outputString += "\n";
            }

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                File.WriteAllText(saveFileDialog1.FileName, outputString);
            }
        }
    }
}
