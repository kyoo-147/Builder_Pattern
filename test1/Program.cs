using System;
using System.Collections.Generic;
namespace test1
// Main
// Tạo một đối tượng Shop.
// Tạo các đối tượng VehicleBuilder cụ thể (scooter, car, motor cycle).
// Gọi phương thức Construct của Shop để xây dựng từng loại phương tiện.
// Gọi phương thức Show để hiển thị thông tin về phương tiện đã xây dựng.
{
    public class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();
            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}
