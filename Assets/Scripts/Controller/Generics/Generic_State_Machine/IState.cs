
namespace GuptaYuddha
{
    public interface IState<T>
    {
        public void OnStateEnter(T stateObject);

        public void OnStateExit();
    }
}

