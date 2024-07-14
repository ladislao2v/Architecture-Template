using Code.Services.AssetProvider;
using Code.Services.SceneLoader;
using Plugins.StateMachine.Core.StateFactory;
using Zenject;

namespace Code.CompositionRoot
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssetProvider();
            BindSceneLoader();
            BindStateFactory();
            BindStateMachine();
        }

        private void BindAssetProvider()
        {
            Container.BindInterfacesAndSelfTo<AssetProvider>().AsSingle();
        }

        private void BindSceneLoader()
        {
            Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();
        }

        private void BindStateMachine()
        {
            Container.BindInterfacesAndSelfTo<Plugins.StateMachine.Core.StateMachine>().AsSingle();
        }

        private void BindStateFactory()
        {
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }
    }
}