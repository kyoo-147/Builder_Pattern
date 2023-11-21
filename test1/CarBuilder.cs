namespace test1;
// CarBuilder: ConcreteBuilder
// Là các lớp cụ thể triển khai VehicleBuilder.
// Mỗi lớp này cài đặt các phương thức BuildFrame, BuildEngine, BuildWheels, và BuildDoors để xây dựng các thành phần của phương tiện.
// Trong constructor, mỗi lớp khởi tạo một đối tượng Vehicle với loại phương tiện tương ứng.Là các lớp cụ thể triển khai VehicleBuilder.
// Mỗi lớp này cài đặt các phương thức BuildFrame, BuildEngine, BuildWheels, và BuildDoors để xây dựng các thành phần của phương tiện.
// Trong constructor, mỗi lớp khởi tạo một đối tượng Vehicle với loại phương tiện tương ứng.
class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Xe Ô Tô");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Khung Xe";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 Phân Khối";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }