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
#line 14 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

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
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Cfabrico.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Cfabrico.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cfabrico")]
    public partial class Cfabrico : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 313 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Cfabrico.razor"
       

    //Declaration of needed objects
    Data.CabecalhoProdutos CCP = new CabecalhoProdutos();
    Data.Servicos servicos = new Servicos();
    Data.CabecalhoProdutos produtos = new CabecalhoProdutos();
    Data.CabecalhosModelos cm = new CabecalhosModelos();
    Data.Colaboradores cl = new Colaboradores();
    Data.TipoDePeca dtdp = new TipoDePeca();
    Data.TipoProduto dtp = new TipoProduto();
    Data.Produtos cp = new Data.Produtos();
    Data.Fornecedores fornecedores = new Data.Fornecedores();
    Data.ClassificacaoProdutos ecp = new Data.ClassificacaoProdutos();
    Data.CabecalhoFabrico CF = new Data.CabecalhoFabrico();
    Data.Fabrico F = new Data.Fabrico();
    Data.Unidades unidade = new Data.Unidades();
    Data.IDMaximo IDMaximo = new Data.IDMaximo();
    Data.HistoricoStock hStock = new Data.HistoricoStock();
    Data.Produtos RProduto = new Data.Produtos();
    Data.CabecalhoProdutos UProduto = new Data.CabecalhoProdutos();

    // Declaration of needed lists
    List<Unidades> listaUnidades = new List<Unidades>();
    List<ClassificacaoProdutos> listaClassificacaoProdutos = new List<ClassificacaoProdutos>();
    List<Fornecedores> listaFornecedores = new List<Fornecedores>();
    List<Servicos> ListaServicos = new List<Servicos>();
    List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
    List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
    List<Data.Produtos> listaProdutos = new List<Produtos>();
    List<CabecalhosModelos> listacabecalhoModeloControllers = new List<CabecalhosModelos>();
    List<Colaboradores> colaboradores = new List<Colaboradores>();
    List<CabecalhoProdutos> listaCabecalhoProduto = new List<CabecalhoProdutos>();

    //For input values
    List<Data.Produtos> LCP = new List<Produtos>();
    List<Data.Fabrico> LCFP = new List<Fabrico>();

    // General variables
    bool Readonly = false;
    int i;
    string formadepesquisa;
    bool ProdutoNovo = true;

    // Function that always runs when someone enter in the page
    protected override async Task OnInitializedAsync()
    {

        // Values that the program search in database
        listaFornecedores = FC.GetAll();
        listacabecalhoModeloControllers = CMC.GetAll();
        listaClassificacaoProdutos = CPC.GetAll();
        listaUnidades = UC.GetAll();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        ListaServicos = SC.GetAll();
        listaCabecalhoProduto = CAPC.GetAll();

        // Initial Values in CFabrico Page
        var res = CAPC.GetMaxID();
        JsRuntime.InvokeVoidAsync("console.log", res);
        CF.datacriacao = DateTime.Now.ToShortDateString();

    }

    // Function that creates the product if new and creates also the cabecalhofabrico and fabrico
    public async Task CriarProduto()
    {
        if (LCP.Count != 0)
        {
            if (ProdutoNovo)
            {
                //Vai buscar o utilizador que está logado
                var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;
                CCP.idmodelo = cm.idmodelo;
                CCP.idclassificação = ecp.IDClassificacao;
                CCP.idunidade = unidade.idunidade;
                CCP.idtipodeproduto = dtp.idtipoproduto;
                CCP.idtipodepeca = dtdp.idpeca;
                hStock.tipocomponente = "Fabrico";
                hStock.idcomponente = CCP.idproduto;
                hStock.tipo = "Entrada";
                hStock.idprodutoalterado = CCP.idproduto;
                hStock.stockinicial = 0;
                hStock.stockfinal = CCP.stock.Value;
                hStockC.Post(hStock);
                hStock = new HistoricoStock();

                var resultado = CAPC.Post(CCP);
                await Task.Delay(1000);
                CF.idproduto = resultado.idproduto;
                var resultado2 = CFC.Post(CF);
                await Task.Delay(1000);

                for (int i = 0; i < LCP.Count; i++)
                {

                    LCP[i].linha = i;
                    //Changes used product stock

                    UProduto = CAPC.Get(LCP[i].idproduto);
                    hStock.stockinicial = UProduto.stock.Value;
                    UProduto.stock = UProduto.stock - LCP[i].quantidade;
                    CAPC.Put(UProduto.idproduto, UProduto);
                    hStock.stockfinal = UProduto.stock.Value;
                    UProduto = new CabecalhoProdutos();
                    // Adds to history
                    hStock.tipocomponente = "Fabrico";
                    hStock.idcomponente = LCP[i].idproduto;
                    hStock.tipo = "Saida";
                    hStock.idprodutoalterado = resultado.idproduto;
                    hStock.stockfinal = UProduto.stock.Value;
                    hStockC.Post(hStock);
                    hStock = new HistoricoStock();
                    PC.Post(LCP[i]);
                    LCFP[i].idfabrico = resultado2.idfabrico;
                    FBCC.Post(LCFP[i]);
                }

                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                cl = new Colaboradores();
                CCP = new CabecalhoProdutos();
                cm = new CabecalhosModelos();
                dtp = new TipoProduto();
                dtdp = new TipoDePeca();
                LCP = new List<Produtos>();
                Readonly = false;
                StateHasChanged();
                OnInitializedAsync();
            }
            else
            {
                CF.idproduto = CCP.idproduto;
                var resultado = CFC.Post(CF);
                await Task.Delay(1000);

                for (int i = 0; i < LCFP.Count; i++)
                {
                    //Product List

                    // Fabrico List
                    //Changes used product stock

                    UProduto = CAPC.Get(LCFP[i].idprodutos.Value);
                    hStock.stockinicial = UProduto.stock.Value;
                    UProduto.stock = UProduto.stock - LCFP[i].quantidade;
                    CAPC.Put(UProduto.idproduto, UProduto);
                    hStock.stockfinal = UProduto.stock.Value;
                    UProduto = new CabecalhoProdutos();
                    // Adds to history
                    hStock.tipocomponente = "Fabrico";
                    hStock.idcomponente = LCFP[i].idprodutos.Value;
                    hStock.tipo = "Saida";
                    hStock.idprodutoalterado = CCP.idproduto;
                    hStock.stockfinal = UProduto.stock.Value;
                    hStockC.Post(hStock);
                    hStock = new HistoricoStock();
                    LCFP[i].idfabrico = CF.idfabrico;
                    FBCC.Post(LCFP[i]);

                }

                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                cl = new Colaboradores();
                CCP = new CabecalhoProdutos();
                cm = new CabecalhosModelos();
                dtp = new TipoProduto();
                dtdp = new TipoDePeca();
                LCP = new List<Produtos>();
                Readonly = false;
                StateHasChanged();
                OnInitializedAsync();
            }
        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossível criar a encomenda, por favor, insira bem os dados da encomenda!");
        }
    }

    // Function that does the selecting in the selected buttons
    public async Task CriarProdutoNovo()
    {

        CCP = new CabecalhoProdutos();
        LCP = new List<Produtos>();
        produtos = new CabecalhoProdutos();
        ProdutoNovo = true;
        listaCabecalhoProduto = CAPC.GetAll();
        CCP.idproduto = 6;
    }

    // Function that does the selecting in the selected buttons
    public async Task UsarProdutoExistente()
    {
        CCP = new CabecalhoProdutos();
        LCP = new List<Produtos>();
        produtos = new CabecalhoProdutos();
        ProdutoNovo = false;
    }

    // Add the compost to a list
    public async Task AdicionarComposto()
    {
        Data.Fabrico fabricocomposto = new Data.Fabrico();

        if (ProdutoNovo)
        {
            if (servicos.idservico != 0)
            {
                i++;
                cp.linha = i;
                cp.custo = cl.valor;
                cp.idcolaborador = cl.idcolaborador;
                cp.idproduto = CCP.idproduto;
                cp.idservico = servicos.idservico;
                cp.descricao = servicos.descricao;
                cp.datacriacao = DateTime.Now.ToString();

                fabricocomposto.linha = i;
                fabricocomposto.custo = cl.valor;
                fabricocomposto.idservico = servicos.idservico;
                fabricocomposto.descricao = servicos.descricao;
                fabricocomposto.customedio = cp.customedio;
                fabricocomposto.custototal = cp.custototal;
                fabricocomposto.datacriacao = DateTime.Now.ToShortDateString();
                fabricocomposto.peso = cp.peso;
                fabricocomposto.quantidade = cp.quantidade;

                LCP.Add(cp);
                LCFP.Add(fabricocomposto);

                cm = new CabecalhosModelos();
                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                cl = new Colaboradores();
                cp = new Produtos();
                fabricocomposto = new Fabrico();

            }
            else if (CCP.idproduto != 0)
            {
                i++;
                cp.linha = i;
                cp.custo = cl.valor;
                cp.idcolaborador = cl.idcolaborador;
                cp.idproduto = produtos.idproduto;
                cp.descricao = produtos.descricao;
                cp.datacriacao = DateTime.Now.ToString();

                fabricocomposto.linha = i;
                fabricocomposto.custo = cl.valor;
                fabricocomposto.idprodutos = produtos.idproduto;
                fabricocomposto.descricao = produtos.descricao;
                fabricocomposto.customedio = cp.customedio;
                fabricocomposto.custototal = cp.custototal;
                fabricocomposto.datacriacao = DateTime.Now.ToShortDateString();
                fabricocomposto.peso = cp.peso;
                fabricocomposto.quantidade = cp.quantidade;
                LCP.Add(cp);
                LCFP.Add(fabricocomposto);

                cm = new CabecalhosModelos();
                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                cl = new Colaboradores();
                cp = new Produtos();
                fabricocomposto = new Fabrico();

            }
            else
            {
                await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
            }
        }
        else
        {

            if (servicos.idservico != 0)
            {
                i++;
                cp.linha = i;
                cp.custo = cl.valor;
                cp.idcolaborador = cl.idcolaborador;
                cp.idservico = servicos.idservico;
                cp.descricao = servicos.descricao;
                cp.datacriacao = DateTime.Now.ToString();

                fabricocomposto.linha = i;
                fabricocomposto.custo = cl.valor;
                fabricocomposto.idservico = servicos.idservico;
                fabricocomposto.descricao = servicos.descricao;
                fabricocomposto.customedio = cp.customedio;
                fabricocomposto.custototal = cp.custototal;
                fabricocomposto.datacriacao = DateTime.Now.ToShortDateString();
                fabricocomposto.peso = cp.peso;
                fabricocomposto.quantidade = cp.quantidade;

                LCP.Add(cp);
                LCFP.Add(fabricocomposto);

                cm = new CabecalhosModelos();
                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                CCP = new CabecalhoProdutos();
                cl = new Colaboradores();
                cp = new Produtos();
                fabricocomposto = new Fabrico();

            }
            else if (produtos.idproduto != 0)
            {
                i++;
                cp.linha = i;
                cp.custo = cl.valor;
                cp.idcolaborador = cl.idcolaborador;
                cp.idproduto = produtos.idproduto;
                cp.descricao = produtos.descricao;
                cp.datacriacao = DateTime.Now.ToString();

                fabricocomposto.linha = i;
                fabricocomposto.custo = cl.valor;
                fabricocomposto.idprodutos = produtos.idproduto;
                fabricocomposto.descricao = produtos.descricao;
                fabricocomposto.customedio = cp.customedio;
                fabricocomposto.custototal = cp.custototal;
                fabricocomposto.datacriacao = DateTime.Now.ToShortDateString();
                fabricocomposto.peso = cp.peso;
                fabricocomposto.quantidade = cp.quantidade;
                LCP.Add(cp);
                LCFP.Add(fabricocomposto);

                cm = new CabecalhosModelos();
                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                cl = new Colaboradores();
                cp = new Produtos();
                fabricocomposto = new Fabrico();


            }
            else
            {
                await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
            }
        }
    }

    public async Task EditarComposto(int linha)
    {
        LCP.RemoveAt(linha - 1);
        LCP.Insert(linha - 1, cp);
    }

    public async Task ApagarComposto(int linha)
    {
        LCP.Remove(listaProdutos[linha - 1]);
    }

    private async Task<IEnumerable<Unidades>> ProcurarUnidades(string searchText)
    {
        return await Task.FromResult(listaUnidades.Where(h => h.indice.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<ClassificacaoProdutos>> ProcurarClassificação(string searchText)
    {
        return await Task.FromResult(listaClassificacaoProdutos.Where(h => h.codigoat.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
    {
        return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Fornecedores>> ProcurarFornecedores(string searchText)
    {
        return await Task.FromResult(listaFornecedores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.nome.ToLower().Contains(searchText.ToLower()) || h.nomevendedor.ToString().Contains(searchText.ToLower())).ToList());
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
        return await Task.FromResult(listaCabecalhoProduto.Where(h => h.descricao.ToLower().Contains(searchText.ToLower()) || h.idproduto.Equals(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhosModelos>> ProcurarModelos(string searchText)
    {
        return await Task.FromResult(listacabecalhoModeloControllers.Where(h => h.idmodelo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipodeCompraController TCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HistoricoStockController hStockC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
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
