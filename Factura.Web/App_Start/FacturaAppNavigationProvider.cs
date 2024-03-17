using Abp.Application.Navigation;
using Abp.Localization;
using FacturaApp.Authorization;

namespace FacturaApp.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class FacturaAppNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Factura,
                        L("Gestion de Facturas"),
                        url: "Facturas",
                        icon: "people"
                        //,
                       // requiredPermissionName: PermissionNames.Pages_Tenants

                  )
                   ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Factura,
                        L("Facturacion"),
                        url: "FacturaModels",
                        icon: "local_offer"
                        //,
                        //requiredPermissionName: PermissionNames.Pages_Tenants
                  )

                    ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Cliente,
                        L("Gestion de Clientes"),
                        url: "Clientes",
                        icon: "people"
                        //,
                        //requiredPermissionName: PermissionNames.Pages_Tenants
                  )

                  //).AddItem(
                  //  new MenuItemDefinition(
                  //      PageNames.Proveedor,
                  //      L("Gestion de Proveedor"),
                  //      url: "Proveedores",
                  //      icon: "people",
                  //      requiredPermissionName: PermissionNames.Pages_Tenants
                  //)
                  //).AddItem(
                  //  new MenuItemDefinition(
                  //      PageNames.Matenimiento,
                  //      L("Tablas de Matenimiento"),
                  //      url: "",
                  //      icon: "business"
                  //       ).AddItem(
                  //  new MenuItemDefinition(
                  //      PageNames.ContacCliente,
                  //      L("Contactos Clientes"),
                  //      url: "contactoClientes",
                  //      icon: "people",
                  //      requiredPermissionName: PermissionNames.Pages_Tenants
                  //  )

                  //  ).AddItem(
                  //  new MenuItemDefinition(
                  //      PageNames.ContacProveedor,
                  //      L("Contactos Proveedor"),
                  //      url: "contactoProveedores",
                  //      icon: "people",
                  //      requiredPermissionName: PermissionNames.Pages_Tenants
                  //  )
                  //  ).AddItem(
                  //  new MenuItemDefinition(
                  //      PageNames.status,
                  //      L("Status"),
                  //      url: "Status",
                  //      icon: "people",
                  //      requiredPermissionName: PermissionNames.Pages_Roles
                  //  )


                    //)





                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people"
                        //,
                        //requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer"
                        //,
                        //requiredPermissionName: PermissionNames.Pages_Roles
                    )
               // )
                //.AddItem(
                //    new MenuItemDefinition(
                //        PageNames.About,
                //        L("About"),
                //        url: "About",
                //        icon: "info"
                //    )
                //).AddItem( //Menu items below is just for demonstration!
                //    new MenuItemDefinition(
                //        "MultiLevelMenu",
                //        L("MultiLevelMenu"),
                //        icon: "menu"
                //    ).AddItem(
                //        new MenuItemDefinition(
                //            "AspNetBoilerplate",
                //            new FixedLocalizableString("ASP.NET Boilerplate")
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetBoilerplateHome",
                //                new FixedLocalizableString("Home"),
                //                url: "https://aspnetboilerplate.com?ref=abptmpl"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetBoilerplateTemplates",
                //                new FixedLocalizableString("Templates"),
                //                url: "https://aspnetboilerplate.com/Templates?ref=abptmpl"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetBoilerplateSamples",
                //                new FixedLocalizableString("Samples"),
                //                url: "https://aspnetboilerplate.com/Samples?ref=abptmpl"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetBoilerplateDocuments",
                //                new FixedLocalizableString("Documents"),
                //                url: "https://aspnetboilerplate.com/Pages/Documents?ref=abptmpl"
                //            )
                //        )
                //    ).AddItem(
                //        new MenuItemDefinition(
                //            "AspNetZero",
                //            new FixedLocalizableString("ASP.NET Zero")
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetZeroHome",
                //                new FixedLocalizableString("Home"),
                //                url: "https://aspnetzero.com?ref=abptmpl"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetZeroDescription",
                //                new FixedLocalizableString("Description"),
                //                url: "https://aspnetzero.com/?ref=abptmpl#description"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetZeroFeatures",
                //                new FixedLocalizableString("Features"),
                //                url: "https://aspnetzero.com/?ref=abptmpl#features"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetZeroPricing",
                //                new FixedLocalizableString("Pricing"),
                //                url: "https://aspnetzero.com/?ref=abptmpl#pricing"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetZeroFaq",
                //                new FixedLocalizableString("Faq"),
                //                url: "https://aspnetzero.com/Faq?ref=abptmpl"
                //            )
                //        ).AddItem(
                //            new MenuItemDefinition(
                //                "AspNetZeroDocuments",
                //                new FixedLocalizableString("Documents"),
                //                url: "https://aspnetzero.com/Documents?ref=abptmpl"
                //            )
                //        )
                //    )
                
            );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, FacturaAppConsts.LocalizationSourceName);
        }
    }
}
