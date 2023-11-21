namespace test1;
// MotorCycleBuilder: ConcreteBuilder
// Là các lớp cụ thể triển khai VehicleBuilder.
// Mỗi lớp này cài đặt các phương thức BuildFrame, BuildEngine, BuildWheels, và BuildDoors để xây dựng các thành phần của phương tiện.
// Trong constructor, mỗi lớp khởi tạo một đối tượng Vehicle với loại phương tiện tương ứng.Là các lớp cụ thể triển khai VehicleBuilder.
// Mỗi lớp này cài đặt các phương thức BuildFrame, BuildEngine, BuildWheels, và BuildDoors để xây dựng các thành phần của phương tiện.
// Trong constructor, mỗi lớp khởi tạo một đối tượng Vehicle với loại phương tiện tương ứng.
class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("Xe Mô Tô");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Khung Xe Mô Tô";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "500 Phân Khối";
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
