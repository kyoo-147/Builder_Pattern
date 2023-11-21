namespace test2;

//Director: Director chịu trách nhiệm thực hiện các bước build theo một trình tự xác định cụ thể
//Class Director là tùy chọn để có Client có thể kiểm soát trực tiếp quá trình.
// Chịu trách nhiệm quản lý quá trình xây dựng đối tượng Product.
// Có một đối tượng IBuilder để thực hiện các bước xây dựng cụ thể.
// Cung cấp các phương thức BuildMinimalViableProduct và BuildFullFeaturedProduct để hướng dẫn builder xây dựng đối tượng Product.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
