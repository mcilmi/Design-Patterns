using AdapterPattern.avaFilters;

namespace AdapterPattern {
    class CaramelFilter : IFilter {
        private Caramel caramel;
        public CaramelFilter(Caramel caramel) {
            this.caramel = caramel;
        }
        public void apply(Image image) {
            this.caramel.init();
            caramel.render(image);
        }
    }
}
