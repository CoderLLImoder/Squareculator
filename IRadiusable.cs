using System;

namespace Squareculator
{
    //Название смешное, я понимаю, но другое не придумал)
    //Идея в том, чтобы можно было использовать этот интерфейс для фигур с радиусом (секторов, колец и т.п.)
    internal interface IRadiusable: IFigure
    {
        double radius { get; }
    }
}
