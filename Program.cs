namespace OTUS_PROTOTYPE
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Создание объектов мебели
            var originalFurniture = new Furniture("Желтый", "Фабрика А");
            var clonedFurniture = (Furniture)originalFurniture.Clone();

            // Создание объектов стула
            var originalChair = new Chair("Синий", "Фабрика А2", 4);
            var clonedChair = (Chair)originalChair.Clone();

            // Создание объектов стула со спинкой
            var originalChairWithBackrest = new ChairWithBackrest("Зеленый", "Фабрика А3", 4, true);
            var clonedChairWithBackrest = (ChairWithBackrest)originalChairWithBackrest.Clone();

            // Демонстрация клонирования
            Console.WriteLine("Original Furniture: Color = {0}, FactoryName = {1}", originalFurniture.Color, originalFurniture.FactoryName);
            Console.WriteLine("Cloned Furniture: Color = {0}, FactoryName = {1}", clonedFurniture.Color, clonedFurniture.FactoryName);

            Console.WriteLine("Original Chair: Color = {0}, FactoryName = {1}, LegCount = {2}", originalChair.Color, originalChair.FactoryName, originalChair.LegCount);
            Console.WriteLine("Cloned Chair: Color = {0}, FactoryName = {1}, LegCount = {2}", clonedChair.Color, clonedChair.FactoryName, clonedChair.LegCount);

            Console.WriteLine("Original Chair With Backrest: Color = {0}, FactoryName = {1}, LegCount = {2}, HasSoftBackrest = {3}", originalChairWithBackrest.Color, originalChairWithBackrest.FactoryName, originalChairWithBackrest.LegCount, originalChairWithBackrest.HasSoftBackrest);
            Console.WriteLine("Cloned Chair With Backrest: Color = {0}, FactoryName = {1}, LegCount = {2}, HasSoftBackrest = {3}", clonedChairWithBackrest.Color, clonedChairWithBackrest.FactoryName, clonedChairWithBackrest.LegCount, clonedChairWithBackrest.HasSoftBackrest);
        }
    }
}
