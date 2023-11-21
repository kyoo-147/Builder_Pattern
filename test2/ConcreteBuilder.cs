namespace test2;
// Concrete Builder: tuân theo Builder Interface cung cấp các triển khai cụ thể của từng bước
// Triển khai giao diện IBuilder.
// Cung cấp các triển khai cụ thể cho từng bước xây dựng.
// Chịu trách nhiệm khởi tạo và cung cấp một đối tượng Product.
// Phương thức GetProduct trả về đối tượng Product đã xây dựng và đặt lại trạng thái của builder để chuẩn bị cho lần xây dựng tiếp theo.

public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }


        public void BuildPartA()
        {
            this._product.Add("GPT");
        }

        public void BuildPartB()
        {
            this._product.Add("GPT-1");
        }

        public void BuildPartC()
        {
            this._product.Add("GPT-2");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
