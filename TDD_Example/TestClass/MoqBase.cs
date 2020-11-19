using Moq;

namespace TestClass
{
    public class MoqBase<TInterface, TInstance> where TInterface : class where TInstance : new()
    {
        protected readonly Mock<TInterface> mock = new Mock<TInterface>();

        public static TInstance Instance()
        {
            return new TInstance();
        }

        public Mock<TInterface> Mock()
        {
            return mock;
        }
    }
}
