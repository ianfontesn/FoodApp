using FoodApp.Menu.Context;

namespace FoodApp.Menu.Repositories.UnitOfWork
{
    public interface IUnityOfWork
    {

        public void Commit();

        public void Rollback();

    }
}
