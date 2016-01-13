using System;
using JavaScript.Html.DOM.CSS;

namespace JavaScript.Html.DOM
{
    public abstract class Context2D : Context
    {
        private Context2D() { }

        /// <summary>
        /// color/pattern/gradient. The fill of the drawing, black is default
        /// </summary>
        public CanvasStyle FillStyle;

        /// <summary>
        /// color/pattern/gradient. The stroke of the drawing, black is default
        /// </summary>
        public CanvasStyle StrokeStyle;

        /// <summary>
        /// The style of the ending of the line, butt is default
        /// </summary>
        public CanvasLineCap LineCap;

        /// <summary>
        /// number	The width of the drawing stroke, 1 is default
        /// </summary>
        public int LineWidth;

        /// <summary>
        /// The style of the corners of the line, miter is default
        /// </summary>
        public CanvasLineJoin LineJoin;

        /// <summary>
        /// The limit size of the corners in a line, default is 10
        /// </summary>
        public int MiterLimit;

        /// <summary>
        /// The color of the shadow, black is default
        /// </summary>
        public Color ShadowColor;

        /// <summary>
        /// The horizontal distance of the shadow, 0 is default
        /// </summary>
        public int ShadowOffsetX;

        /// <summary>
        /// The vertical distance of the shadow, 0 is default
        /// </summary>
        public int ShadowOffsetY;

        /// <summary>
        /// The size of the blurring effect, 0 is default
        /// </summary>
        public int ShadowBlur;

        /// <summary>
        /// Creates a pattern from an image to be used by the fillStyle or strokeStyle attributes
        /// </summary>
        /// <param name="img">Dom Img object</param>
        /// <param name="repeat">repeat, repeat-x, repeat-y, no-repeat</param>
        /// <returns></returns>
        public abstract CanvasPattern CreatePattern(Img img, CanvasRepeat repeat);

        /// <summary>
        /// Creates a gradient object. Use this object as a value to the strokeStyle or fillStyle attributes
        /// four arguments that represent the start point (x0, y0) and end point (x1, y1) of the gradient.
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="z1"></param>
        /// <param name="y1"></param>
        /// <returns></returns>
        public abstract CanvasGradient CreateLinearGradient(double x0, double y0, double z1, double y1);

        /// <summary>
        /// Creates a gradient object as a circle. Use this object as a value to the strokeStyle or fillStyle attributes.
        /// The first three representing the start circle with origin (x0, y0) and radius r0, and the last three representing the end circle with origin (x1, y1) and radius r1.
        /// The values are in coordinate space units.
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="r0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="r1"></param>
        /// <returns></returns>
        public abstract CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1);

        /// <summary>
        /// Draws a filled rectangle using the color/style of the fillStyle attribute
        /// </summary>
        public abstract void FillRect(double x, double y, double w, double h);

        /// <summary>
        /// Draws the lines of a rectangle using the color/style of the strokeStyle attribute
        /// </summary>
        public abstract void StrokeRect(double x, double y, double w, double h);

        /// <summary>
        /// Clears a rectangle area. All pixels inside this area will be erased
        /// </summary>
        public abstract void ClearRect(double x, double y, double w, double h);

        /// <summary>
        /// Starts a new path, or clears the current path
        /// </summary>
        public abstract void BeginPath();

        /// <summary>
        /// Moves the path to the specified point, without creating a line
        /// </summary>
        public abstract void MoveTo(double x, double y);

        /// <summary>
        /// Creates a line (path) from the last point in the path, to the first point. Completes the path
        /// </summary>
        public abstract void ClosePath();

        /// <summary>
        /// Creates a line from the last point in the path to the given point
        /// </summary>
        public abstract void LineTo(double x, double y);

        /// <summary>
        /// Creates a rectangle
        /// </summary>        
        public abstract void Rect(double x, double y, double w, double h);

        /// <summary>
        /// Fills the current path with the selected color, black is default
        /// </summary>
        public abstract void Fill();

        /// <summary>
        /// Creates a stroke/path described with the specified path methods
        /// </summary>
        public abstract void Stroke();

        /// <summary>
        /// Creates an area in the canvas, and this area is the only visible area in the canvas
        /// </summary>
        public abstract void Clip();

        /// <summary>
        /// Creates a quadratic Bwzier curve from the current point in the path to the specified path
        /// </summary>        
        public abstract void QuadraticCurveTo(double cpx, double cpy, double x, double y);

        /// <summary>
        /// Creates a cubic Bezier curve from the current point in the path to the specified path
        /// </summary>
        public abstract void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

        /// <summary>
        /// Creates a circle, or parts of a circle (angle is in radius)
        /// </summary>        
        public abstract void Arc(double x, double y, double r, double sAngle, double eAngle, bool antiClockwise);

        /// <summary>
        /// Creates an arc between two points
        /// </summary>        
        public abstract void ArcTo(double x1, double y1, double x2, double y2, double radius);

        /// <summary>
        /// Returns a Boolean value, true if the specified point is in the path, otherwise false
        /// </summary>
        public abstract bool IsPointInPath(double x, double y);

        public abstract void ScrollPathIntoView();

        /// <summary>
        /// Changing the transformation matrix, Scales the drawings based on the x and y parameters
        /// </summary>
        public abstract void Scale(double x, double y);

        /// <summary>
        /// Changing the transformation matrix, Rotates the drawings based on the given angle
        /// </summary>
        public abstract void Rotate(double angle);

        /// <summary>
        /// Changing the transformation matrix, Moves the drawings horizontally and vertically
        /// </summary>
        public abstract void Translate(double x, double y);

        /// <summary>
        /// Changes the shape of the drawings based on a matrix
        /// </summary>
        public abstract void Transform(double x11, double x12, double x21, double x22, double dx, double dy);

        /// <summary>
        /// Clears the current transformation, then makes the changes of the drawings based on a matrix
        /// </summary>
        public abstract void SetTransform(double x11, double x12, double x21, double x22, double dx, double dy);

        public abstract void DrawImage(Img image, double dx, double dy);
        public abstract void DrawImage(Img image, double dx, double dy, double dw, double dh);
        public abstract void DrawImage(Img image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);

        /// <summary>
        /// Creates a blank imagedata object
        /// </summary>
        /// <returns></returns>
        public abstract CanvasImageData CreateImageData(double w, double h);

        /// <summary>
        /// Creates a blank imagedata object
        /// </summary>
        /// <returns></returns>
        public abstract CanvasImageData CreateImageData(CanvasImageData data);

        /// <summary>
        /// Creates a new imagedata object, containing data from the canvas
        /// </summary>
        /// <returns></returns>
        public abstract CanvasImageData GetImageData(double x, double y, double w, double h);

        public abstract void PutImageData(CanvasImageData data, double dx, double dy);
        public abstract void PutImageData(CanvasImageData data, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight);
        

        /// <summary>
        /// Same as CSS Style.Font
        /// format is "font-style font-variant font-weight font-size line-height font-family"
        /// </summary>
        public string Font;

        /// <summary>
        /// The alignment of the text, "start" is default
        /// </summary>
        public CanvasTextAlign TextAlign;

        /// <summary>
        /// The vertical alignment of the text, "alphabetic" is default
        /// </summary>
        public CanvasTextBaseline TextBaseline;

        /// <summary>
        /// Draws text on the canvas, and fills it with the color set by the fillStyle attribute
        /// </summary>
        public abstract void FillText(string text, double x, double y);

        /// <summary>
        /// Draws text on the canvas, and fills it with the color set by the fillStyle attribute
        /// </summary>
        public abstract void FillText(string text, double x, double y, double maxWidth);

        /// <summary>
        /// Draws text on the canvas, without filling, using the color set by the strokeStyle attribute.
        /// </summary>
        public abstract void StrokeText(string text, double x, double y, double maxWidth);

        /// <summary>
        /// Draws text on the canvas, without filling, using the color set by the strokeStyle attribute.
        /// </summary>
        public abstract void StrokeText(string text, double x, double y);

        /// <summary>
        /// Measures the given text string, returns the result in pixels
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public abstract int MeasureText(string text);

        /// <summary>
        /// Specifies the transparency of the drawings.
        /// from 0.0 (fully transparent) to 1.0 (no additional transparency)
        /// </summary>
        public double GlobalAlpha;

        public CanvasCompositeOperation GlobalCompositeOperation;
    }
}
