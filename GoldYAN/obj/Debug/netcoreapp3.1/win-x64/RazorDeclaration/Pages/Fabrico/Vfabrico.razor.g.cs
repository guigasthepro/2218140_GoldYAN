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
#line 1 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Vfabrico.razor"
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
#line 364 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fabrico\Vfabrico.razor"
       
    Data.CabecalhoProdutos CCP = new CabecalhoProdutos();
    Data.Servicos servicos = new Servicos();
    Data.CabecalhoProdutos produtos = new CabecalhoProdutos();
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
    int iencomenda;
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



    public async Task ApagarItemLista(int i)
    {
        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            PC.DeleteByLinha(LCP[i-1].idproduto, LCP[i-1].linha);
            FBCC.DeleteFabricos(CF.idfabrico, LCP[i-1].idproduto);
            //LCP.RemoveAt(id - 1);
            OnInitializedAsync();

        }
    }

    public void OpenFichaProduto(int id)
    {
        CF = CFC.Get(id);

        dtdp = TPC.Get(cm.idtipodepeca.Value);
        //listaModelos = MC.GetAllQuery(id);
        showModal = true;
    }

    public async Task EditarComposto()
    {
        try
        {
            Data.Fabrico fabricocomposto = new Data.Fabrico();

            if (servicos.idservico != 0)
            {
                i++;
                cp.linha = i;
                cp.custo = cl.valor;
                cp.idcolaborador = cl.idcolaborador;
                cp.idservico = servicos.idservico;
                cp.descricao = servicos.descricao;
                cp.datacriacao = DateTime.Now.ToString();
                if (servicos.custo != 0)
                {
                    cp.custo = servicos.custo;
                    cp.custototal = cp.custo * cp.quantidade;
                    CCP.custototal += cp.quantidade * produtos.preco;
                }
                fabricocomposto.linha = i;
                fabricocomposto.custo = cl.valor;
                fabricocomposto.idservico = servicos.idservico;
                fabricocomposto.descricao = servicos.descricao;
                fabricocomposto.customedio = cp.customedio;
                fabricocomposto.custototal = cp.custototal;
                fabricocomposto.datacriacao = DateTime.Now.ToShortDateString();
                fabricocomposto.peso = cp.peso;
                fabricocomposto.quantidade = cp.quantidade;

                LCP.RemoveAt(iencomenda);
                LCP.Insert(iencomenda, cp);
                PC.Put(cp.idproduto, cp.linha, cp);
                FBCC.Put(fabricocomposto.idfabrico, fabricocomposto.linha, fabricocomposto);



                cm = new CabecalhosModelos();
                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
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
                cp.idprodutos = produtos.idproduto;
                cp.descricao = produtos.descricao;
                cp.datacriacao = DateTime.Now.ToString();
                if (produtos.peso.HasValue)
                {
                    cp.peso = produtos.peso.Value;

                }
                if (produtos.preco.HasValue)
                {
                    cp.custo = produtos.preco.Value;
                    cp.custototal = cp.custo * cp.quantidade;
                    CCP.custototal += cp.custototal;
                }
                fabricocomposto.linha = i;
                fabricocomposto.custo = cl.valor;
                fabricocomposto.idprodutos = produtos.idproduto;
                fabricocomposto.descricao = produtos.descricao;
                fabricocomposto.customedio = cp.customedio;
                fabricocomposto.custototal = cp.custototal;
                fabricocomposto.datacriacao = DateTime.Now.ToShortDateString();
                fabricocomposto.peso = cp.peso;
                fabricocomposto.quantidade = cp.quantidade;

                LCP.RemoveAt(iencomenda);
                LCP.Insert(iencomenda, cp);
                PC.Put(cp.idproduto, cp.linha, cp);
                FBCC.Put(fabricocomposto.idfabrico, fabricocomposto.linha, fabricocomposto);


                cm = new CabecalhosModelos();
                servicos = new Servicos();
                produtos = new CabecalhoProdutos();
                cl = new Colaboradores();
                cp = new Produtos();
                fabricocomposto = new Fabrico();
                js.InvokeVoidAsync("alert", "Produto editado com sucesso!");
                showModal = false;


            }
            else
            {
                await js.InvokeVoidAsync("alert", "Impossivél adicionar, por favor verifique os campos!");
            }
        }
        catch
        {
            js.InvokeVoidAsync("alert", "Ocorreu um erro ao tentar editar.");
        }



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
        CF = CFC.Get(idfabrico);
        CCP = CAPC.Get(CF.idproduto);
        unidade = UC.Get(CCP.idunidade);
        ecp = CPC.Get(CCP.idclassificação);
        dtp = TPRC.Get(CCP.idtipodeproduto);
        dtdp = TPC.Get(CCP.idtipodepeca);
        LCP = PC.GetAllQuery(CF.idproduto);
        if(CCP.idfornecedor.HasValue)
        {
            fornecedores = FC.Get(CCP.idfornecedor.Value);
        }
        unidade = UC.Get(CCP.idunidade);
        listaFabrico = FBCC.GetAllQuery(idfabrico);
        showModal = true;
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

    public async Task LoadLista(int i)
    {
        cp = new Produtos();
        cp = PC.GetProdutoWithLinha(LCP[i - 1].idproduto, LCP[i - 1].linha);
        if(cp.idservico.HasValue)
        {
            servicos = SC.Get(cp.idservico.Value);
            cl = colaboradoresController.Get(cp.idcolaborador);
            cp.formadepesquisa = "Serviço";
        }
        else
        {
            produtos = CAPC.Get(cp.idproduto);
            cp.formadepesquisa = "";
        }


    }

    public async Task SalvarCabecalho()
    {
        try
        {
            CCP.idmodelo = cm.idmodelo;
            CCP.idclassificação = ecp.IDClassificacao;
            CCP.idunidade = unidade.idunidade;
            CCP.idtipodeproduto = dtp.idtipoproduto;
            CCP.idtipodepeca = dtdp.idpeca;
            CCP.idfornecedor = fornecedores.idfornecedor;
            CCP.preco = CCP.custototal;
            CAPC.Put(CCP.idproduto, CCP);
            js.InvokeVoidAsync("alert", "Atualizou o cabeçalho do produto com suceso!");
        }
        catch
        {
            js.InvokeVoidAsync("alert", "Erro ao editar o cabeçalho");
        }
    }


    private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
    {
        return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<CabecalhoProdutos>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaCabecalhoProdutos.Where(h => h.idproduto.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
    {
        return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Unidades>> ProcurarUnidades(string searchText)
    {
        return await Task.FromResult(listaUnidades.Where(h => h.indice.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<ClassificacaoProdutos>> ProcurarClassificação(string searchText)
    {
        return await Task.FromResult(listaClassificacaoProdutos.Where(h => h.codigoat.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Fornecedores>> ProcurarFornecedores(string searchText)
    {
        return await Task.FromResult(listaFornecedores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.nome.ToLower().Contains(searchText.ToLower()) || h.idfornecedor.ToString().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<TipoProduto>> ProcurarTipoProdutos(string searchText)
    {
        return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }







    public async Task ModalCancel3()
    {
        showModal = false;
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