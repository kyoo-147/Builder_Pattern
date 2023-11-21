namespace test2;
//Product: Chỉ sử dụng Builder Pattern khi sản phẩm có nhiều loại và trở nên phức tạp và cần có tỉnh mở rộng.
//Vì đôi khi Concrete builder khác nhau có thể tạo ra những product khác nhau và không liên quan đến nhau.   
// Chứa các phần khác nhau của đối tượng cần xây dựng.
// Cung cấp phương thức Add để thêm các phần vào danh sách.
// Cung cấp phương thức ListParts để hiển thị thông tin về các phần của đối tượng Product.
public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Bộ phận sản phẩm: " + str + "\n";
        }
    }
