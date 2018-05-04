using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTree;
using Shundao.Authorization;

namespace Shundao
{
    [DependsOn(
        typeof(ShundaoCoreModule), 
        typeof(AbpAutoMapperModule),
        typeof(AbpTreeModlue)
        )]
    public class ShundaoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ShundaoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ShundaoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
