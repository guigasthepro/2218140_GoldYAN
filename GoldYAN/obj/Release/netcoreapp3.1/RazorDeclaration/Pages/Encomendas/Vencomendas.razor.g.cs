// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GoldYAN.Pages.Encomendas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Vencomendas.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Vencomendas.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Vencomendas.razor"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Vencomendas.razor"
           [Authorize(Roles = "Admin, Dev, Atendimento, Contabilidade")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vencomendas")]
    public partial class Vencomendas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 496 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Encomendas\Vencomendas.razor"
       

    //Lists

    List<Localizacoes> listLocalizacoes = new List<Localizacoes>();
    List<Estados> listEstados = new List<Estados>();
    List<EncomendasComputed> VEC = new List<EncomendasComputed>();

    // Object Classes
    Data.Estados estado = new Data.Estados();
    Data.Localizacoes localizacao = new Data.Localizacoes();
    bool save = false;



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
    Data.Encomendas detalhencomenda = new Data.Encomendas();
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




    string idencomendaselecionada;
    bool ProdutoNovo = true;
    public string Filter { get; set; }
    bool Readonly;
    bool showModal = false;
    bool showModal2 = false;
    bool showModal3 = false;
    int EncomendaID = 0;
    int EncomendaLinha = 0;
    int i;
    int iencomenda;







    public async Task CriarProduto()
    {
        if (LCP.Count != 0)
        {

            //Vai buscar o utilizador que está logado
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            CCP.idmodelo = cm.idmodelo;
            CCP.idclassificação = ecp.IDClassificacao;
            CCP.idunidade = unidade.idunidade;
            CCP.idtipodeproduto = dtp.idtipoproduto;
            CCP.idtipodepeca = dtdp.idpeca;
            CCP.idfornecedor = fornecedores.idfornecedor;


            CCP.stockantigo = 0;


            if (CCP.updatestock.HasValue)
            {
                CCP.stocktotal = CCP.stock.GetValueOrDefault() + CCP.updatestock.Value;
            }
            else if (CCP.peso.HasValue)
            {
                CCP.stocktotal = CCP.stock.GetValueOrDefault() + CCP.peso.Value;
            }
            else
            {
                js.InvokeVoidAsync("alert", "Impossivel adicionar stock ao produto, o produto foi composto sem stock!");

            }

            if (CCP.stocktotal.HasValue)
            {
                CCP.stock = CCP.stocktotal.Value;
            }

            if (CCP.preco.HasValue)
            {
                if (CCP.margem.HasValue)
                {
                    CCP.preco = CCP.preco * CCP.margem;
                    CCP.pvp = CCP.preco * 1.23;
                }
                else
                {
                    CCP.pvp = CCP.preco * 1.23;
                }
            }

            //if (CCP.peso.HasValue && CCP.cotacao.HasValue && CCP.updatestock.HasValue)
            //{
            //    CCP.preco = (CCP.peso.Value * CCP.cotacao.Value) + CCP.feitiopeca;
            //    CCP.custototal = CCP.preco * CCP.updatestock;

            //}
            //else if (CCP.peso.HasValue && CCP.cotacao.HasValue && !CCP.updatestock.HasValue)
            //{
            //    CCP.preco = (CCP.peso.Value * CCP.cotacao.Value) + CCP.feitiopeca;
            //    CCP.custototal = CCP.preco;
            //}
            //else if (CCP.updatestock.HasValue)
            //{
            //    CCP.preco = CCP.feitiopeca;
            //    CCP.custototal = CCP.preco * CCP.updatestock;
            //}
            //else
            //{
            //    js.InvokeVoidAsync("alert", "Impossivel fazer o preço, o produto vai ser criado sem preço");
            //}




            hStock.tipocomponente = "FAB";
            hStock.tipo = "Entrada";
            hStock.stockinicial = 0;

            if (CCP.updatestock.HasValue)
            {
                hStock.stockadicionado = CCP.updatestock.Value;
            }
            if (CCP.stock.HasValue)
            {
                hStock.stockfinal = CCP.stock.Value;
            }
            hStock.datacriacao = DateTime.Now.ToString("dd/MM/yyyy H:mm");

            var resultado = CAPC.Post(CCP);
            await Task.Delay(1000);

            CF.idproduto = resultado.idproduto;
            CF.idencomenda = idencomendaselecionada;
            EC.UpdateProduto(EncomendaID, EncomendaLinha, resultado.idproduto);
            var resultado2 = CFC.Post(CF);
            hStock.idcomponente = resultado2.idfabrico.ToString();
            hStock.idprodutoalterado = resultado.idproduto;
            hStockC.Post(hStock);
            hStock = new HistoricoStock();
            await Task.Delay(1000);


            for (int i = 0; i < LCP.Count; i++)
            {
                LCP[i].linha = i + 1;
                LCP[i].idproduto = resultado.idproduto;
                if (LCP[i].idprodutos != 0)
                {
                    if(LCP[i].idprodutos.HasValue)
                    {
                        UProduto = CAPC.Get(LCP[i].idprodutos.Value);
                    }
                    if (UProduto.stock.HasValue)
                    {
                        hStock.stockinicial = UProduto.stock.Value;
                    }
                    UProduto.stock = UProduto.stock - LCP[i].quantidade;
                    hStock.stockadicionado = LCP[i].quantidade;
                    CAPC.Put(UProduto.idproduto, UProduto);
                    // Adds to history
                    hStock.tipocomponente = "FAB";
                    hStock.idcomponente = resultado2.idfabrico.ToString();
                    hStock.tipo = "Saida";
                    if (LCP[i].idprodutos.HasValue)
                    {
                        hStock.idprodutoalterado = LCP[i].idprodutos.Value;
                    }
                    hStock.datacriacao = DateTime.Now.ToString("dd/MM/yyyy H:mm");
                    hStock.referenciasaida = resultado.idproduto.ToString() + "-" + resultado.descricao;
                    var resultado4 = hStockC.Post(hStock);
                    hStock = new HistoricoStock();
                    if (UProduto.stock.HasValue)
                    {
                        hStock.stockfinal = UProduto.stock.Value;
                    }
                    UProduto = new CabecalhoProdutos();

                }
                LCFP[i].idfabrico = resultado2.idfabrico;



                var resultado3 = PC.Post(LCP[i]);

                LCFP[i].idfabrico = resultado2.idfabrico;
                var resultado5 = FBCC.Post(LCFP[i]);

                if (resultado.idproduto != 0 && resultado2.idfabrico != 0)
                {
                    js.InvokeVoidAsync("alert", "Fabrico criado com sucesso!");
                }

            }

            LCFP = new List<Fabrico>();
            LCP = new List<Produtos>();
            CCP = new CabecalhoProdutos();
            hStock = new HistoricoStock();
            produtos = new CabecalhoProdutos();
            cp = new Produtos();
            CF = new CabecalhoFabrico();
            cm = new CabecalhosModelos();
            servicos = new Servicos();
            cl = new Colaboradores();
            ecp = new ClassificacaoProdutos();
            unidade = new Unidades();
            dtdp = new TipoDePeca();
            dtp = new TipoProduto();
            fornecedores = new Fornecedores();

        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossível criar a encomenda, por favor, insira bem os dados da encomenda!");
        }
    }

    protected override async Task OnInitializedAsync()
    {
        VEC = EC.GetWithInner();

        listaFornecedores = FC.GetAll();
        listacabecalhoModeloControllers = CMC.GetAll();
        listaClassificacaoProdutos = CPC.GetAll();
        listaUnidades = UC.GetAll();
        listaTipoDePecas = TPC.GetAll();
        listaTipoProdutos = TPRC.GetAll();
        ListaServicos = SC.GetAll();
        listaCabecalhoProduto = CAPC.GetAll();
        colaboradores = colaboradoresController.GetAll();
        // Initial Values in CFabrico Page
        var res = CAPC.GetMaxID();
        JsRuntime.InvokeVoidAsync("console.log", res);
        CF.datacriacao = DateTime.Now.ToShortDateString();
    }

    public bool IsVisible(EncomendasComputed encomendas)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (encomendas.nome.Contains(Filter) || encomendas.telefone.ToString().Contains(Filter) || encomendas.idwithlinha.ToString().Contains(Filter) || encomendas.data.ToString().Contains(Filter))
            return true;

        return false;
    }

    public bool IsVisibleProdutos(CabecalhoProdutos produtos)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (produtos.idproduto.Equals(Filter) || produtos.descricao.ToString().Contains(Filter) || produtos.apontamentos.ToString().Contains(Filter))
            return true;

        return false;
    }

    private async Task<IEnumerable<Localizacoes>> ProcurarLocalizacao(string searchText)
    {
        return await Task.FromResult(listLocalizacoes.Where(h => h.idlocalizacao.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }

    private async Task<IEnumerable<Estados>> ProcurarEstado(string searchText)
    {
        return await Task.FromResult(listEstados.Where(h => h.idestados.ToString().ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }


    public async Task AbrirModalLocalizacao(int id, int linha)
    {
        listLocalizacoes = LocalizacaoC.GetAll();
        EncomendaID = id;
        EncomendaLinha = linha;
        showModal = true;
    }

    public async Task AbrirModalEstado(int id, int linha)
    {
        listEstados = EstadosC.GetAll();
        EncomendaID = id;
        EncomendaLinha = linha;
        showModal2 = true;

    }

    public async Task AbrirModal(string id, int idencomenda, int linha)
    {
        idencomendaselecionada = id;

        detalhencomenda = EC.GetAllQuery(idencomenda, linha);

        showModal3 = true;
    }



    public async Task AdicionarComposto()
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
                cp.custototal = cp.custo * cp.quantidade;
                CCP.preco += cp.quantidade * produtos.preco;
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


            LCP.Add(cp);
            LCFP.Add(fabricocomposto);

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
                CCP.preco += cp.custototal;
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

    public async Task LoadData(int i)
    {
        iencomenda = i;
        cp = LCP[i];
        if (cp.idprodutos.HasValue)
        {
            produtos = CAPC.Get(cp.idprodutos.Value);
        }
        else
        {
            servicos = SC.Get(cp.idservico.Value);
        }
        save = true;
    }


    public async Task LancarLocalizacao()
    {
        var resultado = EC.LancarLocalizacoes(EncomendaID, EncomendaLinha, localizacao.descricao);
        if (resultado != null)
        {
            await js.InvokeVoidAsync("alert", "Localizacao lancado com sucesso");
        }
        else
        {
            await js.InvokeVoidAsync("alert", "Localizacao nao foi lancada");
        }
        EncomendaID = new int();
        showModal = false;
    }

    public async Task LancarEstado()
    {
        var resultado = EC.LancarEstado(EncomendaID, EncomendaLinha, estado.descricao);
        if (resultado != null)
        {
            await js.InvokeVoidAsync("alert", "Localizacao lancado com sucesso");
        }
        else
        {
            await js.InvokeVoidAsync("alert", "Localizacao nao foi lancada");
        }
        EncomendaID = new int();
        showModal2 = false;
    }

    public async Task EditarComposto()
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
                CCP.preco += cp.quantidade * produtos.preco;
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

            LCFP.RemoveAt(iencomenda);
            LCFP.Insert(iencomenda, fabricocomposto);

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
                CCP.preco += cp.custototal;
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

            LCFP.RemoveAt(iencomenda);
            LCFP.Insert(iencomenda, fabricocomposto);

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

    public async Task ApagarItemLista(int i)
    {
        LCP.RemoveAt(i);
    }

    public async Task ModalCancel()
    {
        showModal = false;
    }

    public async Task ModalCancel2()
    {
        showModal2 = false;
    }

    public async Task ModalCancel3()
    {
        showModal3 = false;
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
        return await Task.FromResult(listaFornecedores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.nome.ToLower().Contains(searchText.ToLower()) || h.idfornecedor.ToString().Contains(searchText.ToLower())).ToList());
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

    private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
    {
        return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoController CEC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
