// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Modelos
{
    #line hidden
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
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Cmodelo.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Cmodelo.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Cmodelo.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Cmodelo.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cmodelo")]
    public partial class Cmodelo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 275 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Modelos\Cmodelo.razor"
       
    // Invoking classes
    Data.Servicos servicos = new Servicos();
    Data.Moldes mlds = new Moldes();
    Data.CabecalhoProdutos produtos = new CabecalhoProdutos();
    Data.CabecalhosModelos cm = new CabecalhosModelos();
    Data.Modelos m = new Modelos();
    Data.Colaboradores cl = new Colaboradores();
    Data.TipoDePeca dtdp = new TipoDePeca();
    Data.TipoProduto dtp = new TipoProduto();



    //Invoking lists
    List<Servicos> ListaServicos = new List<Servicos>();
    List<CabecalhoProdutos> listaProdutos = new List<CabecalhoProdutos>();
    List<Moldes> listaMoldes = new List<Moldes>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<Modelos> listaModelos = new List<Modelos>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();



    //Utilitie Stuff
    bool Readonly = true;
    bool ReadonlyCabecalho = true;
    int i;
    string formadepesquisa;
    bool save = false;


    protected override async Task OnInitializedAsync()
    {

        //Cleaning Lists And Class Objects
        ListaServicos = new List<Servicos>();
        servicos = new Servicos();

        colaboradores = colaboradoresController.GetAll();
        listaMoldes = MoldesController.Get();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        ListaServicos = SC.GetAll();
        listaProdutos = CAPC.GetAll();
        servicos.idservico = 0;
    }

    private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
    {
        return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Moldes>> ProcurarMoldes(string searchText)
    {
        return await Task.FromResult(listaMoldes.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idmolde.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoProduto>> ProcurarTipoProdutos(string searchText)
    {
        return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhoProdutos>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaProdutos.Where(h => h.idproduto.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
        m.preco = cl.valor;
    }

    //IFileListEntry file;
    //async Task HandleSelectedFile(IFileListEntry[] files)
    //{
    //    file = files.FirstOrDefault()
    //    if(file != null)
    //    {

    //    }
    //}


    public async Task EditarLista()
    {
        if (mlds.idmolde != 0)
        {
            m.idmolde = mlds.idmolde;
            m.descricao = mlds.descricao;
            m.codigo = mlds.codigo;
            m.idcolaborador = cl.idcolaborador;

            m.preco = cl.valor;

            listaModelos.RemoveAt(m.linha);
            listaModelos.Insert(m.linha,m);

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();

            save = false;


        }
        else if (servicos.idservico != 0)
        {
            m.preco = cl.valor;
            m.idcolaborador = cl.idcolaborador;
            m.idservico = servicos.idservico;
            m.descricao = servicos.descricao;
            m.codigo = servicos.codigo;

            listaModelos.RemoveAt(m.linha);
            listaModelos.Insert(m.linha, m);

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();

            save = false;

        }
        else if (produtos.idproduto != 0)
        {
            m.preco = cl.valor;
            m.idcolaborador = cl.idcolaborador;
            m.idproduto = produtos.idproduto;
            m.descricao = produtos.descricao;

            listaModelos.RemoveAt(m.linha);
            listaModelos.Insert(m.linha, m);

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();

            save = false;

        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
        }
    }

    private async Task AdicionarLista()
    {
        if (mlds.idmolde != 0)
        {
            i++;

            m.linha = i;
            m.idmolde = mlds.idmolde;
            m.descricao = mlds.descricao;
            m.codigo = mlds.codigo;
            m.idcolaborador = cl.idcolaborador;

            m.preco = cl.valor;

            listaModelos.Add(m);

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();



        }
        else if (servicos.idservico != 0)
        {
            i++;

            m.linha = i;
            m.preco = cl.valor;
            m.idcolaborador = cl.idcolaborador;
            m.idservico = servicos.idservico;
            m.descricao = servicos.descricao;
            m.codigo = servicos.codigo;

            listaModelos.Add(m);

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();


        }
        else if (produtos.idproduto != 0)
        {
            i++;

            m.linha = i;
            m.preco = cl.valor;
            m.idcolaborador = cl.idcolaborador;
            m.idproduto = produtos.idproduto;
            m.descricao = produtos.descricao;

            listaModelos.Add(m);

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();


        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
        }

    }

    public async Task CriarEncomenda()
    {
        if (listaModelos.Count != 0)
        {
            //Vai buscar o utilizador que está logado
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            cm.idtipoproduto = dtp.idtipoproduto;
            cm.idtipodepeca = dtdp.idpeca;
            cm.criadopor = user.Identity.Name;
            cm.datacriacao = DateTime.Now;


            var resultado = CMC.Post(cm);
            await Task.Delay(1000);

            for (int i = 0; i < listaModelos.Count; i++)
            {
                listaModelos[i].idmodelo = cm.idmodelo;
                MC.Post(listaModelos[i]);
            }

            m = new Modelos();
            servicos = new Servicos();
            produtos = new CabecalhoProdutos();
            mlds = new Moldes();
            cl = new Colaboradores();
            cm = new CabecalhosModelos();
            dtp = new TipoProduto();
            dtdp = new TipoDePeca();
            listaModelos = new List<Modelos>();
            Readonly = true;
            StateHasChanged();
            OnInitializedAsync();
        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossível criar o modelo, por favor, insira bem os dados do modelo!");
        }
    }

    public async Task AbrirModal(int linha)
    {
        m = listaModelos[linha - 1];

        if (mlds.idmolde != 0)
        {
            if (m.idmolde.HasValue)
            {
                mlds = MoldesController.Get(m.idmolde.Value);
            }
        }
        else if (servicos.idservico != 0)
        {
            if (m.idservico.HasValue)
            {
                servicos = SC.Get(m.idservico.Value);
            }
        }
        else if (produtos.idproduto != 0)
        {
            if (m.idproduto.HasValue)
            {
                produtos = CAPC.Get(m.idproduto.Value);
            }
        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
        }

        save = true;
    }

    public async Task ApagarComposto(int linha)
    {
        listaModelos.RemoveAt(linha -1);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipodeCompraController TCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HistoricoStockController hStockC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersController aspController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosController EstadosC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComprasController ComprasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoComprasController CComprasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FabricoController FBCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoFabricoController CFC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClassificacaoProdutosController CPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UnidadesController UC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancosController VB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProfissoesController ProfissaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MateriasController MateriasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController MoldesController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FornecedoresController FC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoProdutoController TPRC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoPecaController TPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModelosController MC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProdutosController PC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoController CabecalhoEncomendasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoProdutosController CAPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColaboradoresController colaboradoresController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoModeloController CMC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
