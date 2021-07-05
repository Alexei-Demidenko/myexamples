
namespace Head_17_Extentions
{
    public static class ExtensionAreaFigure
    {
        // Площадь прямоугольного треугольника
        public static double RightTriangle(this AreaFigure areaFigure, double CathetusA, double CathetusC) =>
            0.5 * (CathetusA * CathetusC);
    }
}
