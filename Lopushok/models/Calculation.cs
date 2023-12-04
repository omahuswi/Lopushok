using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopushok.models
{
    public class Calculation

    {
        public int CalculateMaterial(int count, double width, double length, string productType, string materialType)
        {
            double area = width * length;
            double coefficient = 1.0;

            // Установка коэффициента в зависимости от типа продукции
            switch (productType)
            {
                case "1":
                    coefficient = 1.1;
                    break;
                case "2":
                    coefficient = 2.5;
                    break;
                case "3":
                    coefficient = 8.43;
                    break;
                default:
                    return -1; // Возврат -1 в случае некорректного типа продукции
            }

            // Расчет общего количества необходимого сырья без учета брака
            double rawMaterial = area * coefficient * count;

            // Установка процента брака в зависимости от типа материала
            double wastePercentage = 0.0;
            switch (materialType)
            {
                case "1":
                    wastePercentage = 0.3 / 100.0;
                    break;
                case "2":
                    wastePercentage = 0.12 / 100.0;
                    break;
                default:
                    return -1; // Возврат -1 в случае некорректного типа материала
            }

            // Расчет общего количества необходимого сырья с учетом брака
            double totalRawMaterial = rawMaterial / (1 - wastePercentage);

            // Округление до ближайшего большего целого
            int requiredRawMaterial = (int)Math.Ceiling(totalRawMaterial);
            return requiredRawMaterial;
        }
    }
}
