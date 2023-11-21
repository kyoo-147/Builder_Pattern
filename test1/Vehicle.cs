namespace test1;
// Vehicle: Product
// Là đối tượng cuối cùng cần được xây dựng.
// Chứa một Dictionary để lưu trữ thông tin về các thành phần của phương tiện (frame, engine, wheels, doors).
// Cung cấp phương thức Show để hiển thị thông tin về phương tiện đã xây dựng.
class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();
        // Constructor
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Loại Phương Tiện: {0}", _vehicleType);
            Console.WriteLine("Loại Khung : {0}", _parts["frame"]);
            Console.WriteLine("Loại Động Cơ : {0}", _parts["engine"]);
            Console.WriteLine(" #Bánh Xe: {0}", _parts["wheels"]);
            Console.WriteLine(" #Cửa Xe : {0}", _parts["doors"]);
        }
    }
