#pragma checksum "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f273e07a855e1d601cc000067359e58044fdcd03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Visualizar), @"mvc.1.0.view", @"/Views/Cliente/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Visualizar.cshtml", typeof(AspNetCore.Views_Cliente_Visualizar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f273e07a855e1d601cc000067359e58044fdcd03", @"/Views/Cliente/Visualizar.cshtml")]
    public class Views_Cliente_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<P_EcoMoura.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 50, true);
            WriteLiteral("\r\n<h3>Produto -> Visualizar</h3>\r\n:)\r\n\r\nRazor:\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
  
    string nome = "Felipe Lisboa";

#line default
#line hidden
            BeginContext(127, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(132, 4, false);
#line 11 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
            EndContext();
            BeginContext(136, 50, true);
            WriteLiteral("</h3>\r\n<br />\r\n<h2>Cliente: </h2>\r\n<b>Código: </b>");
            EndContext();
            BeginContext(187, 8, false);
#line 14 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
          Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(195, 24, true);
            WriteLiteral("<br />\r\n<b>Unidade: </b>");
            EndContext();
            BeginContext(220, 15, false);
#line 15 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
           Write(Model.idEmpresa);

#line default
#line hidden
            EndContext();
            BeginContext(235, 29, true);
            WriteLiteral("<br />\r\n<b>Razão Social: </b>");
            EndContext();
            BeginContext(265, 17, false);
#line 16 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
                Write(Model.razaoSocial);

#line default
#line hidden
            EndContext();
            BeginContext(282, 21, true);
            WriteLiteral("<br />\r\n<b>CNPJ: </b>");
            EndContext();
            BeginContext(304, 10, false);
#line 17 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
        Write(Model.cnpj);

#line default
#line hidden
            EndContext();
            BeginContext(314, 25, true);
            WriteLiteral("<br />\r\n<b>Telefone: </b>");
            EndContext();
            BeginContext(340, 14, false);
#line 18 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
            Write(Model.telefone);

#line default
#line hidden
            EndContext();
            BeginContext(354, 24, true);
            WriteLiteral("<br />\r\n<b>Celular: </b>");
            EndContext();
            BeginContext(379, 13, false);
#line 19 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
           Write(Model.celular);

#line default
#line hidden
            EndContext();
            BeginContext(392, 26, true);
            WriteLiteral("<br />\r\n<b>Saldo BIN: </b>");
            EndContext();
            BeginContext(419, 28, false);
#line 20 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
             Write(Model.saldoBIN.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(447, 28, true);
            WriteLiteral("<br />\r\n<b>Código Rota: </b>");
            EndContext();
            BeginContext(476, 12, false);
#line 21 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
               Write(Model.idRota);

#line default
#line hidden
            EndContext();
            BeginContext(488, 25, true);
            WriteLiteral("<br />\r\n<b>Situação: </b>");
            EndContext();
            BeginContext(514, 14, false);
#line 22 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
            Write(Model.situacao);

#line default
#line hidden
            EndContext();
            BeginContext(528, 54, true);
            WriteLiteral("<br />\r\n\r\n<br />\r\nTodos os direitos reservados &copy; ");
            EndContext();
            BeginContext(583, 17, false);
#line 25 "C:\Users\Felipe Hisano\Desktop\Sistemas de Informação\7º Termo\0007. Projeto Integrado de Sistemas II\Projeto-EcoMoura\P_EcoMoura\P_EcoMoura\Views\Cliente\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<P_EcoMoura.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591