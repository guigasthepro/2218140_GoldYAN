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
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ABancos.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ABancos.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ABancos.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ABancos.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ABancos.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bancos")]
    public partial class ABancos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 155 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\ABancos.razor"
       
    List<GoldYAN.Data.Bancos> VBS = new List<GoldYAN.Data.Bancos>();

    Data.Bancos updateBanco = new Bancos();

    Data.Bancos criarBanco = new Bancos();

    bool showModal = false;
    bool showModal2 = false;

    protected override async Task OnInitializedAsync()
    {
        VBS = VB.Get();

        foreach (var banco in @VBS)
        {
            updateBanco.idbanco = banco.idbanco;
            updateBanco.codigobanco = banco.codigobanco;
            updateBanco.nome = banco.nome;
        }

    }

    public async Task Apagar(int id)
    {

        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            string message = VB.Delete(id);
            OnInitializedAsync();
            Task.Delay(1000);
            {
                await js.InvokeVoidAsync("alert", @message);
            }
        }
    }

    public async Task Update()
    {
        VB.Put(updateBanco.idbanco, updateBanco);
        showModal = false;
    }

    public async Task Criar()
    {
        var resultado = VB.Post(criarBanco);
        StateHasChanged();
        showModal2 = false;
        VBS = VB.Get();
        
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancosController VB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
