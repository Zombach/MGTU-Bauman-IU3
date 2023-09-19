using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Vidmanov.Task1.Part2;

/// <summary>
/// Вариант №3. Найти координаты центра тяжести треугольника на плоскости, то есть
/// координаты точки, лежащей на медиане и отстоящей на 2/3 ее длины от вершины, из
/// которой медиана проведена. Для проверки результата выполнить вычисления для всех
/// трех медиан. Проверить работу программы также для равнобедренного прямоугольного
/// треугольника с координатами вершин (0; 0), (3; 0), (0; 3), где решение очевидно.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        Triangle triangle = new(0, 0, 3, 0, 0, 3);
        float centerGravityX = triangle.CenterGravityX;
        float centerGravityY = triangle.CenterGravityY;
    }
}