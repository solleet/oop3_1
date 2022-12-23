using oop3_1.Transports;

namespace oop3_1
{
    public class Tests
    {
        // ���� 1 �������� ������� ������� ��� �����
        [TestCase(120, 15, 2250)]
        [TestCase(113, 17, 2262.5)]
        [TestCase(94, 12, 1775)]
        public void TaxiTest(int i, int j, double k)
        {
            Taxi taxi = new(i, j);

            Assert.That(taxi.Revenue, Is.EqualTo(k));
        }

        // ���� 2 �������� ������� ������� ��� ����������
        [TestCase(17, 9, 14, 6, 9, 4, 3885)]
        [TestCase(20, 12, 9, 6, 10, 7, 5423)]
        [TestCase(10, 6, 7, 5, 13, 5, 1797.5)]
        public void TrainTest(int a, int b, int c, int d, int e, int f, double k)
        {
            Train train = new(a, b, c, d, e, f);

            Assert.That(train.Revenue, Is.EqualTo(k));
        }

        // ���� 3 �������� ������� ������� ��� ��������
        [TestCase(56, 42, 12, 30, 2786)]
        [TestCase(42, 32, 15, 24, 2211)]
        [TestCase(31, 26, 20, 17, 1798)]
        public void BusTest(int a, int b, int c, int d, double k)
        {
            Bus bus = new(a, b, c, d);

            Assert.That(bus.Revenue, Is.EqualTo(k));
        }

        // ���� 4 �������� ������� ������ �������
        [Test]
        public void TotalTest()
        {
            Taxi taxi = new(94, 12);
            Train train = new(20, 12, 9, 6, 10, 7);
            Bus bus = new(31, 26, 20, 17);

            Flight flight = new(taxi, train, bus);

            Assert.That(flight.TotalRevenue, Is.EqualTo(8996));
        }

        // ���� 5 �������� ������ ��� ����������-�����
        [Test]
        public void TaxiPrintTest()
        {
            Taxi taxi = new(94, 12);
            string tString = $"{taxi.Tipe} : {taxi.Revenue}";
            string expectedString = "Taxi : 1775";
            Assert.AreEqual(expectedString, tString);
        }

        // ���� 6 �������� ������ ��� ����������-����������
        [Test]
        public void TrainPrintTest()
        {
            Train train = new(17, 9, 14, 6, 9, 4);
            string tString = $"{train.Tipe} : {train.Revenue}";
            string expectedString = "Train : 3885";
            Assert.AreEqual(expectedString, tString);
        }

        // ���� 7 �������� ������ ��� ����������-��������
        [Test]
        public void BusPrintTest()
        {
            Bus bus = new(56, 42, 12, 30);
            string tString = $"{bus.Tipe} : {bus.Revenue}";
            string expectedString = "Bus : 2786";
            Assert.AreEqual(expectedString, tString);
        }

        // ���� 8 �������� ������������ ������� ��� �����
        [Test]
        public void TaxiRevenueTest()
        {
            Taxi taxi = new(94, 12);

            Assert.AreEqual(taxi.Revenue, taxi.RevenueCalculation());
        }

        // ���� 9 �������� ������������ ������� ��� ����������
        [Test]
        public void TrainRevenueTest()
        {
            Train train = new(17, 9, 14, 6, 9, 4);

            Assert.AreEqual(train.Revenue, train.RevenueCalculation());
        }

        // ���� 10 �������� ������������ ������� ��� ��������
        [Test]
        public void BusRevenueTest()
        {
            Bus bus = new(56, 42, 12, 30);

            Assert.AreEqual(bus.Revenue, bus.RevenueCalculation());
        }
    }
}
