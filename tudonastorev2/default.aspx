<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Tudonastorev2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
	

			
			

			<section class="slider" id="home">
				<div class="container-fluid">
					<div class="row">

					    <div id="carouselHacked" class="carousel slide carousel-fade" data-ride="carousel">
							<div class="header-backup"></div>
					        <!-- Wrapper for slides -->
					        <div class="carousel-inner" role="listbox">
					            <div class="item active">
					            	<img src="img/slide-one.jpg" alt="">
					                <div class="carousel-caption">
				               			<h1>Produtos naturais</h1>
				               			<p>Temos os principais produtos naturais para sua dieta</p>
				               			<button href="#team">saiba mais</button>
					                </div>
					            </div>
					            <div class="item">
					            	<img src="img/slide-two.jpg" alt="">
					                <div class="carousel-caption">
				               			<h1>Cereais Matinais</h1>
				               			<p>Um café da manhã equilibrado com chia, linhaça, aveia, etc.</p>
				               			<button href="#team">saiba mais</button>
					                </div>
					            </div>
					            <div class="item">
					            	<img src="img/slide-three.jpg" alt="">
					                <div class="carousel-caption">
				               			<h1>Chás</h1>
				               			<p>Diversidade de chás para seu lazer e fins medicinais</p>
				               			<button href="#team">saiba mais</button>
					                </div>
					            </div>
					            <div class="item">
					            	<img src="img/slide-four.jpg" alt="">
					                <div class="carousel-caption">
				               			<h1>Refeição equilibrada</h1>
				               			<p>É necessário ter uma refeição equilibrada</p>
				               			<button href="#team">saiba mais</button>
					                </div>
					            </div>
					        </div>

					        <!-- Controls -->
					        <a class="left carousel-control" href="#carouselHacked" role="button" data-slide="prev">
					            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
					            <span class="sr-only">Previous</span>
					        </a>
					        <a class="right carousel-control" href="#carouselHacked" role="button" data-slide="next">
					            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
					            <span class="sr-only">Next</span>
					        </a>
					    </div>

					</div>
				</div>
			</section><!-- end of slider section -->


			<!-- about section -->
			<section class="about text-center" id="about">
				<div class="container">
					<div class="row">
						<h2>Sobre nós</h2>
						<h4>A loja tudo natural para você, é uma loja voltada para melhorar o “seu bem estar”, está em
pleno funcionamento desde janeiro de 2014, oferecendo produtos naturais de qualidade,
nacionais e importados, voltados para contribuir com sua saúde e te oferecer mais qualidade
de vida. Tudo com preços justos e acessíveis.</br>
A loja comercializa produtos orgânicos, sem lactose e sem glutem.</br>
Oferecemos tanbém alimentos funcionais, detox, chás para diversos fins, além de pomadas e
cremes.</br>
Entre em contato conosco, através de seu canal favorito.</br></h4>

						<div class="col-md-4 col-sm-6">
							<div class="single-about-detail clearfix">
								<div class="about-img">
									<img src="img/about1.jpg" alt="" style="height:200px">
								</div>

								<div class="about-details">
									<div class="pentagon-text">
										<h1>T</h1>
									</div>

									<h3>Telefone</h3>
									<p>Façã seu pedido com toda a comodidade ligando para o nosso telefone. Atendemos de segunda a sábado das 09 as 18hrs.</p>
								</div> 
							</div>
						</div>

						<div class="col-md-4 col-sm-6">
							<div class="single-about-detail">
								<div class="about-img">
									<img class="img-responsive" src="img/about2.jpg" alt="" style="height:200px" >
								</div>

								<div class="about-details">
									<div class="pentagon-text">
										<h1>W</h1>
									</div>

									<h3>Whatsapp</h3>
									<p>Prefere um meio mais rápido? Pode fazer o seu contato pelo whatsapp nossos atendentes estarão disponiveis para pegar o seu pedido.</p>
								</div>
							</div>
						</div>


						<div class="col-md-4 col-sm-6">
							<div class="single-about-detail">
								<div class="about-img">
									<img class="img-responsive" src="img/about3.jpg" alt="" style="height:200px">
								</div>

								<div class="about-details">
									<div class="pentagon-text">
										<h1>L</h1>
									</div>

									<h3>Loja Fisica</h3>
									<p>Contamos com uma loja física onde você pode nos visitar na região de Hortolândia, assim você pode comprar e já sair com seu produto. Venha nos visitar.</p>
								</div>
							</div>
						</div>

					</div>
				</div>
			</section><!-- end of about section -->


			<!-- service section starts here -->

			<!---<section class="service text-center" id="service">
				<div class="container">
					<div class="row">
						<h2>our services</h2>
						<h4>Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</h4>

						<div class="col-md-3 col-sm-6">
							<div class="single-service">
								<div class="single-service-img">
									<div class="service-img">
										<img class="img-responsive" src="img/service1.png" alt="">
									</div>
								</div>
								<h3>Consulting</h3>
							</div>
						</div>

						<div class="col-md-3 col-sm-6">
							<div class="single-service">
								<div class="single-service-img">
									<div class="service-img">
										<img class="img-responsive" src="img/service2.png" alt="">
									</div>
								</div>
								<h3>Financial</h3>
							</div>
						</div>

						<div class="col-md-3 col-sm-6">
							<div class="single-service">
								<div class="single-service-img">
									<div class="service-img">
										<img class="img-responsive" src="img/service3.png" alt="">
									</div>
								</div>
								<h3>Tax Help</h3>
							</div>
						</div>

						<div class="col-md-3 col-sm-6">
							<div class="single-service">
								<div class="single-service-img">
									<div class="service-img">
										<img class="img-responsive" src="img/service4.png" alt="">
									</div>
								</div>
								<h3>Money</h3>
							</div>
						</div>
					</div>
				</div>
			</section>--><!-- end of service section -->


			<!-- team section -->

			<section class="team" id="team">
				<div class="container">
					<div class="row">
						<div class="team-heading text-center">
						<br><br>
							<h2>Nossos Produtos</h2>

							<h4>Oferecemos uma grande gama de produtos naturais confira abaixo </h4>
						</div>

						<div class="col-md-2 single-member col-sm-4">
							<div class="person">
								<img class="img-responsive" src="img/item1.jpg" alt="member-1">
							</div>

							<div class="person-detail">
								<div class="arrow-bottom"></div>
								<h3>Beleza</h3>
								<p>Temos Argilas, todas as cores, para máscaras faciais, Dolomita, p/ máscaras de Porcelana, Diversos tipós Sabonetes , Sabonetes íntimo. </p>
							</div>
						
						</div>

						<div class="col-md-2 single-member col-sm-4">

							<div class="person-detail">
								<div class="arrow-top"></div>
								<h3>Chás</h3>
								<p>Temos para pronta entrega chás calmantes, digestivos, chas para melhorar o funcionamento do intestino e rins, chás diuréticos e muito mais.</p>
							</div>
							<div class="person">
								<img class="img-responsive" src="img/item2.jpg" alt="member-2">
							</div>
						</div>
						<div class="col-md-2 single-member col-sm-4">
							<div class="person">
								<img class="img-responsive" src="img/item3.jpg" alt="member-3">
							</div>
							<div class="person-detail">
								<div class="arrow-bottom"></div>
								<h3>Fitness</h3>
								<p>Oferecemos alimentos funcionais, Linhaça, Chia, Quinua, Amaranto, Psilium, Aveia, Uva passa, Ameixas e Castanhas, tudo para uma alimentação saudável.

</p>
							</div>
						</div>

						<div class="col-md-2 single-member col-sm-4">
							<div class="person-detail">
								<div class="arrow-top"></div>
								<h3>Saúde</h3>
								<p>Temos muitas opções de chás e capsulas e óleos, pomadas e cremes para auxilio nas dores 100% naturais para melhorar sua saúde.</p>
							</div>
							<div class="person">
								<img class="img-responsive" src="img/item4.jpg" alt="member-4">
							</div>
						</div>

						<div class="col-md-2 single-member col-sm-4">
							<div class="person">
								<img class="img-responsive" src="img/item5.jpg" alt="member-5">
							</div>

							<div class="person-detail">
								<div class="arrow-bottom"></div>
								<h3>Emagrecimento</h3>
								<p>Gama de produtos como chás Seca Barriga, alimentos funcionais, capsulas 100% naturais, produtos termogénicos, e calmantes.</p>
							</div>
						</div>

						<div class="col-md-2 single-member col-sm-4">

							<div class="person-detail">
								<div class="arrow-top"></div>
								<h3>Vitaminas</h3>
								<p>Além dos alimentos funcionais, temos várias opções de vitaminas que visam complementar as necessidades diárias desses elementos.</p>
							</div>
							<div class="person">
								<img class="img-responsive" src="img/item6.jpg" alt="member-5">
							</div>

						</div>
					</div>
				</div>
			</section><!-- end of team section -->

	
			<section class="api-map" id="contact">
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-12 map" id="map"></div>
					</div>
				</div>
			</section>

	
			<section class="contact">
				<div class="container">
					<div class="row">
							<div class="contact-caption clearfix">
								<div class="contact-heading text-center">
									<h2>Contato</h2>
								</div>

								<div class="col-md-5 contact-info text-left">
									<h3>Informação para contato</h3>
									<div class="info-detail">
										<ul><li><i class="fa fa-calendar"></i><span>Segunda - Sábado:</span> 9:00 as 18:00 PM</li></ul>
										<ul><li><i class="fa fa-map-marker"></i><span>Endereço:</span> <div id="dEndereco" runat="server" /></li></ul>
										<ul><li><i class="fa fa-phone"></i><span>Telefone:</span> <span id="dPhone" runat="server" /></li></ul>
										<ul><li><i class="fa fa-fax"></i><span>Whatsapp:</span> <span id="dZap" runat="server" /></li></ul>
										<ul><li><i class="fa fa-envelope"></i><span>Email:</span> <span id="dEmail" runat="server" /></li></ul>
									</div>
								</div>


								<div class="col-md-6 col-md-offset-1 contact-form">
									<h3>Mande um mensagem</h3>

									<form class="form"  runat="server" method="post">
                                        <asp:Label ID="Label1" runat="server" ></asp:Label>
                                        <input class="name" type="text" placeholder="Name" name="name" id="name" runat="server" >
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="name" runat="server" ErrorMessage="Preencha o seu nome" BackColor="Red"></asp:RequiredFieldValidator>
										<input class="email" type="email" placeholder="Email" name="email" id="email" runat="server">
                                        <asp:RegularExpressionValidator  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="email" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Favor prencher um e-mail valido" BackColor="Red"></asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator ControlToValidate="email" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Preencha a mensagem corretamente" BackColor="Red"></asp:RequiredFieldValidator>                                            
										<textarea class="message" name="mensagem" id="mensagem" cols="30" rows="10" placeholder="Message" runat="server" ></textarea>
                                        <asp:RequiredFieldValidator ControlToValidate="mensagem" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Preencha a mensagem corretamente" BackColor="Red"></asp:RequiredFieldValidator>                                            
                                        <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
									</form>
								</div>

							</div>
					</div>	
				</div>
			</section><!-- end of contact section -->


			<!-- footer starts here -->
			<footer class="footer clearfix">
				<div class="container">
					<div class="row">
						<div class="col-xs-6 footer-para">
							
						</div>

						<div class="col-xs-6 text-right">
							<a href="https://www.facebook.com/Tudo-Natural-Para-Você-410588736174078/"><i class="fa fa-facebook"></i></a>
						</div>
					</div>
				</div>
			</footer>



	

	<!-- script tags
	============================================================= -->
	<script src="js/jquery-2.1.1.js"></script>
	<script src="js/smoothscroll.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script src="js/custom.js"></script>
</asp:Content>
