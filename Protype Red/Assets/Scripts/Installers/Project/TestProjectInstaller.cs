using UnityEngine;
using Zenject;

public class TestProjectInstaller : MonoInstaller
{
    [SerializeField] private CreaturesInfo creaturesInfo;
    public override void InstallBindings()
    {
        Container.Bind<ICreaturesInfo>().FromInstance(creaturesInfo).AsSingle();
    }
}