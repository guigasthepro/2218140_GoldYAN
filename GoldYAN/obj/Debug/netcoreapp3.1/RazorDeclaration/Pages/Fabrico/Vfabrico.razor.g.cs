// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Fabrico
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Vfabrico.razor"
           [Authorize(Roles = "Admin, Dev, Contabilidade")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vfabrico")]
    public partial class Vfabrico : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 400 "C:\Users\gsimao\source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Vfabrico.razor"
       
    Data.CabecalhoProdutos CCP = new CabecalhoProdutos();
    Data.Servicos servicos = new Servicos();
    Data.Produtos produtos = new Produtos();
    Data.CabecalhosModelos cm = new CabecalhosModelos();
    Data.Colaboradores cl = new Colaboradores();
    Data.TipoDePeca dtdp = new TipoDePeca();
    Data.TipoProduto dtp = new TipoProduto();
    Data.Produtos cp = new Produtos();
    Data.Fornecedores fornecedores = new Data.Fornecedores();
    Data.CabecalhoFabrico cfabrico = new Data.CabecalhoFabrico();
    Data.ClassificacaoProdutos ecp = new Data.ClassificacaoProdutos();
    Data.CabecalhoFabrico CF = new Data.CabecalhoFabrico();
    Data.Fabrico F = new Data.Fabrico();
    Data.Unidades unidade = new Data.Unidades();
    Data.IDMaximo IDMaximo = new Data.IDMaximo();
    Data.HistoricoStock hStock = new Data.HistoricoStock();
    Data.Produtos RProduto = new Data.Produtos();
    Data.CabecalhoProdutos UProduto = new Data.CabecalhoProdutos();
    List<Data.Produtos> GProduto = new List<Data.Produtos>();


    List<Data.Fabrico> LCFP = new List<Fabrico>();



    List<Unidades> listaUnidades = new List<Unidades>();
    List<ClassificacaoProdutos> listaClassificacaoProdutos = new List<ClassificacaoProdutos>();
    List<Fornecedores> listaFornecedores = new List<Fornecedores>();
    List<Servicos> ListaServicos = new List<Servicos>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<Fabrico> listaFabrico = new List<Fabrico>();
    List<HistoricoStock> listaHistoricoStocks = new List<HistoricoStock>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<CabecalhoProdutos> listaCabecalhoProdutos = new List<CabecalhoProdutos>();
    List<Data.Produtos> listaProdutos = new List<Produtos>();
    List<CabecalhosModelos> listacabecalhoModeloControllers = new List<CabecalhosModelos>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();
    List<CabecalhoFabrico> listaCabecalhoFabrico = new List<CabecalhoFabrico>();
    List<CabecalhoFabrico> listCFabrico = new List<CabecalhoFabrico>();


    //For input values
    List<Data.Produtos> LCP = new List<Produtos>();

    bool FichaModelo = false;

    bool showModal = false;
    bool Readonly = true;
    bool ReadonlyCabecalho = true;
    int i;
    int iencoemnda;
    string formadepesquisa;
    public string Filter { get; set; }


    protected override async Task OnInitializedAsync()
    {
        listaCabecalhoFabrico = CFC.GetAll();

    }

    public bool IsVisible(CabecalhoFabrico fabricos)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (fabricos.idfabrico.Equals(Filter) || fabricos.datacriacao.ToString().Contains(Filter) || fabricos.idproduto.ToString().Contains(Filter))
            return true;

        return false;
    }

    public void OpenFichaProduto(int id)
    {
        //cm = CMC.Get(id);
        //dtp = TPRC.Get(cm.idtipoproduto.Value);
        dtdp = TPC.Get(cm.idtipodepeca.Value);
        //listaModelos = MC.GetAllQuery(id);
        showModal = true;
    }
    void ModalShow()
    {
        showModal = true;
    }
    void ModalCancel()
    {
        showModal = false;
    }


    public async Task LoadData(int idfabrico)
    {
        cfabrico = CFC.Get(idfabrico);
        listaFabrico = FBCC.GetAllQuery(idfabrico);
    }

    public async Task Apagar(int idfabrico, int idproduto)
    {
        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            listaFabrico = FBCC.GetAllQuery(idfabrico);
            for (int i = 0; i < listaFabrico.Count; i++)
            {
                if (listaFabrico[i].idprodutos.HasValue)
                {
                    listaHistoricoStocks = hStockC.GetAllQuery(idfabrico, listaFabrico[i].idprodutos.Value);
                    CCP = CAPC.Get(listaFabrico[i].idprodutos.Value);
                    if (listaHistoricoStocks.Count != 0)
                    {
                        if (listaHistoricoStocks[0].tipo == "Entrada")
                        {
                            CCP.stock = CCP.stock - listaHistoricoStocks[0].stockadicionado;
                            CAPC.Put(CCP.idproduto, CCP);
                        }
                        else
                        {
                            CCP.stock = CCP.stock + listaHistoricoStocks[0].stockadicionado;
                            CAPC.Put(CCP.idproduto, CCP);
                        }
                    }
                }
                if (listaFabrico[i].idprodutos.HasValue)
                {
                    PC.DeleteProdutos(listaFabrico[i].idprodutos.Value, listaFabrico[i].idfabrico);
                    FBCC.DeleteFabricos(idfabrico, listaFabrico[i].idprodutos.Value);
                    hStockC.DeleteUsingFabricos(listaFabrico[i].idprodutos.Value, idfabrico);
                }

            }
            CCP = new CabecalhoProdutos();
            listaHistoricoStocks = new List<HistoricoStock>();

            CCP = CAPC.Get(idproduto);
            listaHistoricoStocks = hStockC.GetAllQuery(idfabrico, idproduto);

            if (CCP != null)
            {
                if (listaHistoricoStocks[0].tipo == "Entrada")
                {
                    CCP.stock = CCP.stock - listaHistoricoStocks[0].stockadicionado;
                    CAPC.Put(CCP.idproduto, CCP);
                }
                else
                {
                    CCP.stock = CCP.stock + listaHistoricoStocks[0].stockadicionado;
                    CAPC.Put(CCP.idproduto, CCP);
                }
            }
            CAPC.Put(CCP.idproduto, CCP);

            var resultado = CFC.Delete(idfabrico);
            if (resultado != null)
            {
                js.InvokeVoidAsync("alert", "Fabrico apagado com sucesso");
            }
            OnInitializedAsync();
            Task.Delay(1000);

        }
    }

    public async Task Update()
    {

        //CMC.Put(cm.idmodelo, cm);
        //foreach (var modelos in listaModelos)
        //{
        //}
        //showModal = false;
    }

    private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
    {
        return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoProduto>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
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
