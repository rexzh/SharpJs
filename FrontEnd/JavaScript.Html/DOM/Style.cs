using System;
using JavaScript.Html.DOM.CSS;

namespace JavaScript.Html.DOM
{
    public class Style
    {
        #region Background
        /// <summary>
        /// Sets or returns all the background properties in one declaration
        /// format is: "color image repeat attachment position"
        /// </summary>
        public string Background;

        /// <summary>
        /// Sets or returns whether a background-image is fixed or scrolls with the page
        /// </summary>
        public BackgroundAttachment BackgroundAttachment;

        /// <summary>
        /// Sets or returns the background-color of an element
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>
        public Color BackgroundColor;

        /// <summary>
        /// Sets or returns the background-image for an element
        /// url('URL')|none|inherit
        /// </summary>
        public StyleImage BackgroundImage;

        /// <summary>
        /// Sets or returns the starting position of a background-image
        /// <para>x% y%	The x value indicates the horizontal position and the y value indicates the vertical position. The top left corner is 0% 0%. The right bottom corner is 100% 100%. If you only specify one value, the other value will be 50%.</para>
        /// <para>xpos ypos	The x value indicates the horizontal position and the y value indicates the vertical position. The top left corner is 0 0. Units can be pixels (0px 0px) or any other CSS units. If you only specify one value, the other value will be 50%. You can mix % and units</para>
        /// </summary>
        public BackgroundPosition BackgroundPosition;

        /// <summary>
        /// Sets or returns how to repeat (tile) a background-image
        /// </summary>
        public BackgroundRepeat BackgroundRepeat;
        #endregion

        #region Border/Outline
        /// <summary>
        /// Sets or returns border-width, border-style, and border-color in one declaration
        /// format is: "width style color"
        /// </summary>
        public string Border;

        /// <summary>
        /// Sets or returns all the borderBottom properties in one declaration
        /// format is: "width style color"
        /// </summary>
        public string BorderBottom;

        /// <summary>
        /// Sets or returns all the borderRight properties in one declaration
        /// format is: "width style color"
        /// </summary>
        public string BorderRight;

        /// <summary>
        /// Sets or returns all the borderTop properties in one declaration
        /// format is: "width style color"
        /// </summary>
        public string BorderTop;

        /// <summary>
        /// Sets or returns all the borderLeft properties in one declaration
        /// format is: "width style color"
        /// </summary>
        public string BorderLeft;

        /// <summary>
        /// Sets or returns the color of an element's border (can have up to four values)       
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>        
        public Color BorderColor;

        /// <summary>
        /// Sets or returns the color of the bottom border
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>
        public Color BorderBottomColor;

        /// <summary>
        /// Sets or returns the color of the left border
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>
        public Color BorderLeftColor;

        /// <summary>
        /// Sets or returns the color of the right border
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>
        public Color BorderRightColor;

        /// <summary>
        /// Sets or returns the color of the top border
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>
        public Color BorderTopColor;

        /// <summary>
        /// Sets or returns the style of an element's border
        /// </summary>
        public BorderStyle BorderStyle;

        /// <summary>
        /// Sets or returns the style of the bottom border
        /// </summary>
        public BorderStyle BorderBottomStyle;

        /// <summary>
        /// Sets or returns the style of the left border
        /// </summary>    
        public BorderStyle BorderLeftStyle;

        /// <summary>
        /// Sets or returns the style of the right border
        /// </summary>
        public BorderStyle BorderRightStyle;

        /// <summary>
        /// Sets or returns the style of the top border
        /// </summary>
        public BorderStyle BorderTopStyle;

        /// <summary>
        /// Sets or returns the width of an element's border
        /// Build in value or the width of the border in length units 
        /// </summary>
        public BorderWidth BorderWidth;

        /// <summary>
        /// Sets or returns the width of the bottom border
        /// Build in value or the width of the border in length units 
        /// </summary>
        public BorderWidth BorderBottomWidth;

        /// <summary>
        /// Sets or returns the width of the left border
        /// Build in value or the width of the border in length units 
        /// </summary>
        public BorderWidth BorderLeftWidth;

        /// <summary>
        /// Sets or returns the width of the right border
        /// Build in value or the width of the border in length units 
        /// </summary>
        public BorderWidth BorderRightWidth;

        /// <summary>
        /// Sets or returns the width of the top border
        /// Build in value or the width of the border in length units 
        /// </summary>
        public BorderWidth BorderTopWidth;

        /// <summary>
        /// Sets or returns the width of the outline around an element
        /// Build in value or the width of the border in length units 
        /// </summary>
        public BorderWidth OutlineWidth;

        /// <summary>
        /// Sets or returns all the outline properties in one declaration
        /// <para>format is: "width style color"</para>
        /// <para>or inherit</para>
        /// </summary>
        public string Outline;

        /// <summary>
        /// Sets or returns the color of the outline around a element
        /// <see cref="Color"/>
        /// <para>or inherit|transparent</para>
        /// </summary>
        public Color OutlineColor;

        /// <summary>
        /// Sets or returns the style of the outline around an element
        /// </summary>
        public BorderStyle OutlineStyle;
        #endregion

        #region Margin/Padding

        /// <summary>
        /// Sets or returns the margins of an element
        /// <para>Build in value (exclude none) or</para>
        /// <para>%    Defines the bottom margin in % of the width of the parent element</para>
        /// <para>length   Defines the bottom margin in length units</para>
        /// </summary>        
        public Distance Margin;

        /// <summary>
        /// Sets or returns the bottom margin of an element
        /// <para>Build in value (exclude none) or</para>
        /// <para>%    Defines the bottom margin in % of the width of the parent element</para>
        /// <para>length   Defines the bottom margin in length units</para>
        /// </summary>        
        public Distance MarginBottom;


        /// <summary>
        /// Sets or returns the left margin of an element
        /// <para>Build in value (exclude none) or</para>
        /// <para>%    Defines the bottom margin in % of the width of the parent element</para>
        /// <para>length   Defines the bottom margin in length units</para>
        /// </summary>        
        public Distance MarginLeft;


        /// <summary>
        /// Sets or returns the right margin of an element
        /// <para>Build in value (exclude none) or</para>
        /// <para>%    Defines the bottom margin in % of the width of the parent element</para>
        /// <para>length   Defines the bottom margin in length units</para>
        /// </summary>        
        public Distance MarginRight;


        /// <summary>
        /// Sets or returns the top margin of an element
        /// <para>Build in value (exclude none) or</para>
        /// <para>%    Defines the bottom margin in % of the width of the parent element</para>
        /// <para>length   Defines the bottom margin in length units</para>
        /// </summary>        
        public Distance MarginTop;


        /// <summary>
        /// Sets or returns the padding of an element
        /// <para>Build in value (except auto and none) or</para>
        /// <para>%	Defines the bottom padding in % of the width of the parent element</para>
        /// <para>length	Defines the bottom padding in length units</para>
        /// </summary>        
        public Distance Padding;


        /// <summary>
        /// Sets or returns the bottom padding of an element
        /// <para>Build in value (except auto and none) or</para>
        /// <para>%	Defines the bottom padding in % of the width of the parent element</para>
        /// <para>length	Defines the bottom padding in length units</para>
        /// </summary>        
        public Distance PaddingBottom;

        /// <summary>
        /// Sets or returns the left padding of an element
        /// <para>Build in value (except auto and none) or</para>
        /// <para>%	Defines the bottom padding in % of the width of the parent element</para>
        /// <para>length	Defines the bottom padding in length units</para>
        /// </summary>        
        public Distance PaddingLeft;

        /// <summary>
        /// Sets or returns the right padding of an element
        /// <para>Build in value (except auto and none) or</para>
        /// <para>%	Defines the bottom padding in % of the width of the parent element</para>
        /// <para>length	Defines the bottom padding in length units</para>
        /// </summary>        
        public Distance PaddingRight;

        /// <summary>
        /// Sets or returns the top padding of an element
        /// <para>Build in value (except auto and none) or</para>
        /// <para>%	Defines the bottom padding in % of the width of the parent element</para>
        /// <para>length	Defines the bottom padding in length units</para>
        /// </summary>        
        public Distance PaddingTop;

        #endregion


        /// <summary>
        /// Sets or returns the contents of a style declaration as a string
        /// </summary>
        public string CssText;


        #region Positioning/Layout

        /// <summary>
        /// Sets or returns the bottom position of a positioned element
        /// <para>Build in value (except none) or</para>
        /// <para>length	Defines the bottom position in length units. Negative values are allowed</para>para>
        /// <para>%	Sets the bottom position in % of the height of the parent element</para>
        /// </summary>
        public Distance Bottom;

        /// <summary>
        /// Sets or returns the left position of a positioned element
        /// <para>Build in value (except none) or</para>
        /// <para>length	Defines the left position in length units. Negative values are allowed</para>
        /// <para>%	Sets the left position in % of the width of the parent element</para>
        /// </summary>
        public Distance Left;

        /// <summary>
        /// Sets or returns the right position of a positioned element
        /// <para>Build in value (except none) or</para>
        /// <para>length	Defines the right position in length units. Negative values are allowed</para>
        /// </para>%	Sets the right position in % of the width of the parent element</para>
        /// </summary>
        public Distance Right;

        /// <summary>
        /// Sets or returns the width of an element
        /// <para>Build in value (except none) or</para>
        /// <para>length	Defines the width in length units</para>
        /// <para>%	Defines the width in % of the parent element</para>
        /// </summary>
        public Distance Width;

        /// <summary>
        /// Sets or returns the height of an element
        /// <para>Build in value (except none) or</para>
        /// <para>length	Defines the height in length units</para>
        /// <para>%	Defines the height in % of the parent element</para>
        /// </summary>
        public Distance Height;

        /// <summary>
        /// Sets or returns the top position of a positioned element
        /// <para>Build in value (except none) or</para>
        /// <para>length	Defines the top position in length units. Negative values are allowed</para>
        /// <para>%	Sets the top position in % of the height of the parent element</para>
        /// </summary>
        public Distance Top;

        /// <summary>
        /// Sets or returns the position of the element relative to floating objects
        /// </summary>
        public Clear Clear;

        /// <summary>
        /// Sets or returns the horizontal alignment of an object
        /// </summary>
        public CssFloat CssFloat;

        /// <summary>
        /// Sets or returns the type of cursor to display for the mouse pointer
        /// <para>Build in value or</para>
        /// <para>url: The URL of a cursor file to be used. Tip: Always define a generic cursor at the end of the list in case none of the url-defined cursors work</para>
        /// </summary>
        public Cursor Cursor;

        /// <summary>
        /// Sets or returns an element's display type
        /// </summary>
        public Display Display;

        /// <summary>
        /// Sets or returns the stack order of a positioned element
        /// <para>Build in value or</para>
        /// <para>number: An integer that defines the stack order of the element. Negative values are allowed</para>
        /// </summary>
        public ZIndex ZIndex;

        /// <summary>
        /// Sets or returns what to do with content that renders outside the element box
        /// </summary>
        public Overflow Overflow;

        /// <summary>
        /// Sets or returns the type of positioning method used for an element (static, relative, absolute or fixed)
        /// </summary>
        public Position Position;

        /// <summary>
        /// Sets or returns whether an element should be visible
        /// </summary>
        public Visibility Visibility;

        /// <summary>
        /// Sets or returns the vertical alignment of the content in an element
        /// </summary>
        public VerticalAlign VerticalAlign;

        /// <summary>
        /// Sets or returns the maximum height of an element
        /// <para>Build in value(none|inherit) or</para>
        /// <para>length:Defines the maximum width in length units</para>
        /// <para>%: Defines the maximum width in % of the parent element</para>
        /// </summary>
        public Distance MaxHeight;

        /// <summary>
        /// Sets or returns the maximum width of an element
        /// <para>Build in value(none|inherit) or</para>
        /// <para>length:Defines the maximum height in length units</para>
        /// <para>%: Defines the maximum height in % of the parent element</para>
        /// </summary>
        public Distance MaxWidth;

        /// <summary>
        /// Sets or returns the minimum height of an element
        /// <para>Build in value inherit or</para>
        /// <para>%: Defines the minimum height in % of the parent element</para>
        /// <para>length: Defines the minimum width in length units. Default is 0</para>
        /// </summary>
        public Distance MinHeight;

        /// <summary>
        /// Sets or returns the minimum width of an element
        /// <para>Build in value inherit or</para> 
        /// <para>%: Defines the minimum width in % of the parent element</para>
        /// <para>length: Defines the minimum width in length units. Default is 0</para>
        /// </summary>
        public Distance MinWidth;

        /// <summary>
        /// Sets or returns which part of a positioned element is visible
        /// Build in value or rect(top right bottom left) with units
        /// </summary>
        public Clip Clip;

        #endregion

        #region Text

        /// <summary>
        /// Sets or returns the color of the text
        /// </summary>
        public Color Color;

        /// <summary>
        /// Sets or returns font
        /// format is "font-style font-variant font-weight font-size line-height font-family"
        /// </summary>
        public string Font;

        /// <summary>
        /// Sets or returns the text direction
        /// </summary>
        public Direction Direction;

        /// <summary>
        /// Sets or returns whether the style of the font is normal, italic or oblique
        /// </summary>
        public FontStyle FontStyle;

        /// <summary>
        /// Sets or returns whether the font should be displayed in small capital letters
        /// </summary>
        public FontVariant FontVariant;

        /// <summary>
        /// Sets or returns the boldness of the font
        /// </summary>
        public FontWeight FontWeight;

        /// <summary>
        /// Sets or returns the font size of the text
        /// <para>Build in value or</para>
        /// <para>length: Defines the font-size in length units</para>
        /// <para>%: Sets the font-size to a % of  the parent element's font size</para>
        /// </summary>
        public FontSize FontSize;

        /// <summary>
        /// Sets or returns the distance between lines in a text
        /// Build in value or
        /// <para>number:A number that will be multiplied with the current font size to set the line height</para>
        /// <para>length:Defines the line height in length units</para>
        /// <para>%:Defines the line height in % of the current font size</para>
        /// </summary>
        public LineHeight LineHeight;

        /// <summary>
        /// Sets or returns the font face for text
        /// </summary>
        public string FontFamily;//Extend:font family, maybe can use + between 2 instance of font???

        /// <summary>
        /// Sets or returns the space between characters in a text
        /// Build in value or
        /// <para>length: Defines the space in length units. Negative values are allowed</para>
        /// </summary>
        public LetterSpacing LetterSpacing;

        /// <summary>
        /// Sets or returns the horizontal alignment of text
        /// </summary>
        public TextAlign TextAlign;

        /// <summary>
        /// Sets or returns the decoration of a text
        /// </summary>
        public TextDecoration TextDecoration;

        /// <summary>
        /// Sets or returns the indentation of the first line of text
        /// Build in value or
        /// <para>length: Defines the indentation in length units. Default value is 0</para>
        /// <para>%: Defines the indentation in % of the width of the parent element</para>
        /// </summary>
        public TextIndent TextIndent;

        /// <summary>
        /// Sets or returns the case of a text
        /// </summary>
        public TextTransform TextTransform;

        /// <summary>
        /// Sets or returns whether the text should be overridden to support multiple languages in the same document
        /// </summary>
        public UnicodeBidi UnicodeBidi;

        /// <summary>
        /// Sets or returns how to handle tabs, line breaks and whitespace in a text
        /// </summary>
        public WhiteSpace WhiteSpace;

        /// <summary>
        /// Sets or returns the spacing between words in a text
        /// Build in value or
        /// <para>length: Specifies the space between words in length units. Negative values are allowed</para>
        /// </summary>
        public WordSpacing WordSpacing;

        #endregion
    }
}
