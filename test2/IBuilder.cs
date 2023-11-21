namespace test2;
// IBuilder: Builder: chỉ định các phương phương pháp để tạo các phần khác nhau Product object 
// Định nghĩa các phương thức cần thiết để xây dựng các phần khác nhau của đối tượng Product.
public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
