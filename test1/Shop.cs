namespace test1;
// Shop: Director
// Là một lớp chỉ đạo xây dựng của phương tiện.
// Cung cấp phương thức Construct, nhận một đối tượng VehicleBuilder và thực hiện các bước xây dựng cơ bản 
// (BuildFrame, BuildEngine, BuildWheels, BuildDoors).
class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
