// Программа которая возвращает номер четверти плоскости (по оси координат) 
//в которой эта точка находится

int faindQuadrant(double x, double y)  //это название метода, где int- тип метода
{                                      //faindQuadrant- название метода
if (x>0 && y>0) return 1;              //в скобках (double x, double y) аргументы метода 
if (x<0 && y>0) return 2;    //в фигурных скобках
if (x<0 && y<0) return 3;    //решение метода
if (x>0 && y<0) return 4;
return 0; //данная строка если хоть одна точка на самой оси координат (те на нуле)
}  // далее прописываем, как выводить в консоль
Console.Write("Input an x-coordinate:  "); //выводит в консоль х координату которую надо заполнить
double xA= Convert.ToDouble(Console.ReadLine());  //xA ставим чтобы не конфликтовало с первой строкой, где есть x

Console.Write("Input an y-coordinate:  "); //выводит в консоль н координату которую надо заполнить
double yA= Convert.ToDouble(Console.ReadLine());

int Quadnum= faindQuadrant(xA, yA); // это переменная значения которое нужно найти

Console.WriteLine($"The point ({xA},{yA} is on the {Quadnum} Quandrant");
//последняя строка это вывод, т.е. мы написали точка координат
// находится в четверти
