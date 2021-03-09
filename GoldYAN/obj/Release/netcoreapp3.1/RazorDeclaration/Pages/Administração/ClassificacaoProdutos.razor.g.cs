// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Administração
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ClassificacaoProdutos.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ClassificacaoProdutos.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/classificacaoprodutos")]
    public partial class ClassificacaoProdutos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 191 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ClassificacaoProdutos.razor"
       
    List<GoldYAN.Data.ClassificacaoProdutos> VCPS = new List<GoldYAN.Data.ClassificacaoProdutos>();

    Data.ClassificacaoProdutos updateCP = new Data.ClassificacaoProdutos();

    Data.ClassificacaoProdutos criarCP = new Data.ClassificacaoProdutos();

    bool showModal = false;
    bool showModal2 = false;


    protected override async Task OnInitializedAsync()
    {
        VCPS = VCP.Get();

        foreach (var banco in @VCPS)
        {
            updateCP.IDClassificacao = banco.IDClassificacao;
            updateCP.descricao = banco.descricao;
            updateCP.codigo = banco.codigo;
            updateCP.codigoat = banco.codigoat;
            updateCP.inventario = banco.inventario;
        }

    }

    public async Task Apagar(int id)
    {

        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            string message = VCP.Delete(id);
            OnInitializedAsync();
            Task.Delay(1000);
            {
                await js.InvokeVoidAsync("alert", @message);
            }
        }
    }

    public async Task Update()
    {
        VCP.Put(updateCP.IDClassificacao, updateCP);
        showModal = false;
    }

    public async Task Criar()
    {
        var resultado = VCP.Post(criarCP);
        StateHasChanged();
        showModal2 = false;
        VCPS = VCP.Get();

    }


    void ModalShow()
    {
        showModal = true;
    }
    void ModalCancel()
    {
        showModal = false;
    }
    void ModalShow2()
    {
        showModal2 = true;
    }
    void ModalCancel2()
    {
        showModal2 = false;
    }

    void ModalOk()
    {
        Console.WriteLine("Modal ok");
        showModal = false;
    }

    public string Filter { get; set; }

    public bool IsVisible(Data.ClassificacaoProdutos clp)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (clp.codigo.ToString().Contains(Filter) || clp.codigoat.ToString().Contains(Filter) || clp.descricao.ToString().Contains(Filter))
            return true;

        return false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClassificacaoProdutosController VCP { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
