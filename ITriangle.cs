using System;

namespace Squareculator
{
    internal interface ITriangle: IFigure
    {
        //Наверно, правильнее делать три свойста, но мне показалось удобнее работать с массивом длин сторон
        double[] sides { get; }

        bool isRight { get; }
    }
}
