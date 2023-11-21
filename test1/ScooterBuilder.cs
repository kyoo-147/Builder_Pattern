namespace test1;
// ScooterBuilder: ConcreteBuilder
// Là các lớp cụ thể triển khai VehicleBuilder.
// Mỗi lớp này cài đặt các phương thức BuildFrame, BuildEngine, BuildWheels, và BuildDoors để xây dựng các thành phần của phương tiện.
// Trong constructor, mỗi lớp khởi tạo một đối tượng Vehicle với loại phương tiện tương ứng.Là các lớp cụ thể triển khai VehicleBuilder.
// Mỗi lớp này cài đặt các phương thức BuildFrame, BuildEngine, BuildWheels, và BuildDoors để xây dựng các thành phần của phương tiện.
// Trong constructor, mỗi lớp khởi tạo một đối tượng Vehicle với loại phương tiện tương ứng.
class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Xe Scooter");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Khung Xe Scooter";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "50 Phân Khối";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
