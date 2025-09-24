using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Класс, хранящий основные цвета, задействованные в интерфейсе приложения <see cref="AppColors"/>.
    /// </summary>
    static public class AppColors
    {
        ///<summary> 
        /// Цвет окна при выбранном параметре "Autumn".
        ///</sumarry>
        static public System.Drawing.Color AutumnColor = ColorTranslator.FromHtml("#e29c45");
        ///<summary> 
        /// Цвет окна при выбранном параметре "Spring".
        ///</sumarry>
        static public System.Drawing.Color SpringColor = ColorTranslator.FromHtml("#559c45");
        ///<summary> 
        /// Цвет textBox элементов при некорректном вводе.
        ///</sumarry>
        static public System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;
        ///<summary> 
        /// Цвет Panel элемента при отсутствии пересечений.
        ///</sumarry>
        static public System.Drawing.Color OkColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
        ///<summary> 
        /// Цвет Panel элемента при пересечении с другим прямоугольником.
        ///</sumarry>
        static public System.Drawing.Color CollisionColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
        ///<summary> 
        /// Цвет выбранного в ListBox Panel элемента.
        ///</sumarry>
        static public System.Drawing.Color HighlightColor = System.Drawing.Color.LightGoldenrodYellow;
    }
}
