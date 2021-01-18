<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MilkParlorSystem.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html lang="en">
<head>
<title>Milk Parlor System</title>
	
	<!-- Meta tag Keywords -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta charset="utf-8">
	<meta name="keywords" content="Web Booster Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
	Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
	<script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!--// Meta tag Keywords -->
    
	<!-- css files -->
	<link rel="stylesheet" href="css/bootstrap.css"> <!-- Bootstrap-Core-CSS -->
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" /> <!-- Style-CSS --> 
	<link rel="stylesheet" href="css/fontawesome-all.css"> <!-- Font-Awesome-Icons-CSS -->
	<!-- //css files -->
	
	<link rel="stylesheet" href="css/flexslider.css" type="text/css" media="screen" />
	
	<!--web font-->
	<link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=latin-ext" rel="stylesheet">
	<!--//web font-->

</head>

<body>
<header>	
<div class="container">
<!-- nav -->
		<nav class="navbar navbar-expand-lg navbar-light py-4">
			<!-- logo -->
			<h1>
				<a class="navbar-brand" href="index.html"> <i class="fas fa-globe"></i>
					Milk Parlor System <span></span>
				</a>
			</h1>
			<!-- //logo -->
			<button class="navbar-toggler ml-md-auto" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
				aria-expanded="false" aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>
			<!-- main nav -->
			<div class="collapse navbar-collapse" id="navbarSupportedContent">
				<ul class="navbar-nav ml-lg-auto text-center">
					<li class="nav-item active mr-lg-2">
						<a class="nav-link" href="index.html">Home
							<span class="sr-only">(current)</span>
						</a>
					</li>
					<li class="nav-item mr-lg-2">
						<a class="nav-link scroll" href="#welcome">about</a>
					</li>
					
					<li class="nav-item mr-2">
						<a class="nav-link " href="Login.aspx">Login</a>
					</li>
					
				</ul>
			</div>
			<!-- //main nav -->
		</nav>
		<!-- //nav -->
</div>
</header>
		
<!-- banner -->
<div class="banner">
	<div class="banner-layer">
		<div class="container">
			<div class="agile_banner_info">
				<div class="agile_banner_info1">
					<div id="typed-strings" class="agileits_w3layouts_strings">
						<p>Boost Your <i>Business.</i></p>
						<p>We Are <i>Creative</i> Agency.</p>
						<p><i>Professional </i>Management.</p>
						<p>We Make <i>System Better...</i></p>
					</div>
					<span id="typed" style="white-space:pre;"></span>
				</div>
			<div class="banner_agile_para">
				
			</div>
			
			</div>
		</div>
	</div>
</div>
<!-- //banner -->	

<!-- about -->
<section class="welcome py-5" id="welcome">
	<div class="container">
		<div class="head_part">
			<h3 class="heading">About Us</h3>
			<p class="heading-bottom mb-5">Few Words Of Our Project</p>
		</div>
		<div class="row">
			<div class="col-lg-7 welcome_left">
				<%--<h3 class="mb-3">consectetur adipiscing elit</h3>
				<h4 class="mb-3">Vestibulum utrisus</h4>--%>
				<p>The number of people who are purchasing milk/milk products are just increasing day by day. Using this automated system, we can effectively keep accurate track of the quantity of milk/milk products sold, amount collected, quantity of milk/milk products in demand etc. Whichever information is needed it would be available at our finger tips at a very short period of time and also it reduces manual stress and cost efficiency for the milk parlor agents as well as diary agents.</p>
				
				
				<%--<div class="row about-grids">
					<div class="col-md-4 about-grid1">
						<h3>consectetur</h3>
						<p>Ullamcorper Non, ipsum hendrerit in nisi</p>
					</div>
					<div class="col-md-4 about-hover-grid">
						<h3>consectetur</h3>
						<p>Ullamcorper Non, ipsum hendrerit in nisi</p>
					</div>
					<div class="col-md-4 about-hover-grid">
						<h3>consectetur</h3>
						<p>Ullamcorper Non, ipsum hendrerit in nisi</p>
					</div>
				</div>--%>
				
			</div>
			<div class="col-lg-5 welcome_right mt-lg-0 mt-5">
				<div class="row grid1">
					<div class="col-md-3 col-sm-2 col-3 icon color1 text-center">
						<span class="fas fa-info-circle" aria-hidden="true"></span>
					</div>
					<div class="col-md-9 col-sm-10 col-9 grid_info">
						<h3 class="mb-2">Quality Business </h3>
						<p>cost efficient</p>
					</div>
				</div>
				<div class="row grid2">
					<div class="col-md-3 col-sm-2 col-3 icon color1 text-center">
						<span class="fas fa-info-circle" aria-hidden="true"></span>
					</div>
					<div class="col-md-9 col-sm-10 col-9 grid_info">
						<h3 class="mb-2">Less Time</h3>
						<p>Reduces manual stress and time</p>
					</div>
				</div>
				<div class="row grid3">
					<div class="col-md-3 col-sm-2 col-3 icon color1 text-center">
						<span class="fas fa-users" aria-hidden="true"></span>
					</div>
					<div class="col-md-9 col-sm-10 col-9 grid_info">
						<h3 class="mb-2">Support Management</h3>
						<p>Easy way to keep track of Milk Product order,stock & sales Details</p>
					</div>
				</div>
			</div>
		</div>
	</div>
</section>
<!-- //about -->

<!-- services -->

<!-- services -->

<!-- pricing -->

<!-- //pricing -->




<!-- stats -->

<!-- //team -->

<!-- contact -->

<!-- //contact -->

<!-- footer -->	
<footer class="py-5">
	<div class="container">
		<div class="row">
			<div class="col-lg-3 col-sm-6 agileinfo_footer_grid footer-logo">
				<h2><a href="#"><i class="fas fa-globe"></i>
					Milk Parlor System <span></span></a></h2>
			</div>
			<div class="col-lg-2 col-sm-6 agileinfo_footer_grid">
				<h3 class="mb-3"> Navigation</h3> 
				<div class="agileinfo-social-grids footer-w3icons">
					<ul>
						<li class="mb-1"><a href="#"><i class="fa fa-home"></i>  Home</a></li>
						<li class="mb-1"><a href="#"><i class="fa fa-home"></i> About Us</a></li>
						
					</ul>
				</div>
			</div>
			<div class="col-lg-3 col-sm-6 mt-lg-0 mt-sm-5 mt-3 agileinfo_footer_grid">
				<h3 class="mb-3"> Address</h3> 
				<ul class="con_inner_text">
					<li class="mb-2"><span class="fa fa-map-marker" aria-hidden="true"></span>Virajpet, <label> Coorg.</label></li>
					
				</ul>
			</div>
			
			
			<!-- copyright -->
			<div class="col-lg-6 copyleft pl-0 pt-4 mt-4">
				<p>© 2019 Milk Parlor System. All Rights Reserved | Design by <a href="#" target="_blank">Milk Parlor Team</a></p>
			</div>
			<div class="col-lg-6 copyright pr-0 pt-4 mt-4">
				<ul class="social">
					<li class="mr-3"><span class="fab mr-1 fa-facebook-f" aria-hidden="true"></span>Facebook</li>
					<li class="mr-3"><span class="fab mr-1 fa-twitter" aria-hidden="true"></span>Twitter</li>
					<li class="mr-3"><span class="fab mr-1 fa-linkedin" aria-hidden="true"></span>Linkedin</li>
					<li class=""><span class="fab mr-1 fa-google-plus" aria-hidden="true"></span>Google-plus</li>
				</ul>
			</div>
			<!-- //copyright -->
			
		</div>
	</div>
</footer>
<!-- footer -->

	<!-- Vertically centered Modal -->
	<div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
	  <div class="modal-dialog modal-dialog-centered" role="document">
		<div class="modal-content">
		  <div class="modal-header">
			<h5 class="modal-title text-capitalize text-center" id="exampleModalLongTitle"><span class="fas fa-globe"></span> Web <span class="logo">Booster</span></h5>
			<button type="button" class="close" data-dismiss="modal" aria-label="Close">
			  <span aria-hidden="true">&times;</span>
			</button>
		  </div>
		  <div class="modal-body">
			<img src="images/banner1.jpg" class="img-fluid mb-3" alt="Modal Image" />
			Vivamus eget est in odio tempor interdum. Mauris maximus in fermentum arcu, ac finibus ante. Sed mattis risus at ipsum at elementum, ut auctor turpis cursus. Sed sed odio pharetra, aliquet velit cursus, vehicula enim. Mauris porta aliquet sed magnain, eget laoreet ligula. mollit anim id est laborum.
		  </div>
		  <div class="modal-footer">
			<button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
			<button type="button" class="btn btn-primary">Save changes</button>
		  </div>
		</div>
	  </div>
	</div>
	<!-- //Vertically centered Modal -->

	<!-- js -->
	<script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script> <!-- Necessary-JavaScript-File-For-Bootstrap --> 
	<!-- //js -->	
	
	<!-- banner-type-text -->
		<script src="js/typed.js" type="text/javascript"></script>
		<script>
		    $(function () {

		        $("#typed").typed({
		            // strings: ["Typed.js is a <strong>jQuery</strong> plugin.", "It <em>types</em> out sentences.", "And then deletes them.", "Try it out!"],
		            stringsElement: $('#typed-strings'),
		            typeSpeed: 30,
		            backDelay: 500,
		            loop: false,
		            contentType: 'html', // or text
		            // defaults to false for infinite loop
		            loopCount: false,
		            callback: function () { foo(); },
		            resetCallback: function () { newTyped(); }
		        });

		        $(".reset").click(function () {
		            $("#typed").typed('reset');
		        });

		    });

		    function newTyped() { /* A new typed object */ }

		    function foo() { console.log("Callback"); }
		</script>
	<!-- //banner-type-text -->
	
	<!-- Stats-Number-Scroller-Animation-JavaScript -->
	<script src="js/waypoints.min.js"></script> 
	<script src="js/counterup.min.js"></script> 
	<script>
	    jQuery(document).ready(function ($) {
	        $('.counter').counterUp({
	            delay: 10,
	            time: 1000
	        });
	    });
	</script>
	<!-- //Stats-Number-Scroller-Animation-JavaScript -->

	<!-- flexslider --><!-- for testimonials -->
	<script defer src="js/jquery.flexslider.js"></script>
	<!--Start-slider-script-->
		<script type="text/javascript">

		    $(window).load(function () {
		        $('.flexslider').flexslider({
		            animation: "slide",
		            start: function (slider) {
		                $('body').removeClass('loading');
		            }
		        });
		    });
	  </script>
	<!--End-slider-script-->
	<!-- //flexslider --><!-- //for testimonials -->

	<!-- start-smoth-scrolling -->
	<script src="js/SmoothScroll.min.js"></script>
	<script type="text/javascript" src="js/move-top.js"></script>
	<script type="text/javascript" src="js/easing.js"></script>
	<script type="text/javascript">
	    jQuery(document).ready(function ($) {
	        $(".scroll").click(function (event) {
	            event.preventDefault();
	            $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
	        });
	    });
	</script>
	<!-- here stars scrolling icon -->
	<script type="text/javascript">
	    $(document).ready(function () {
	        /*
	        var defaults = {
	        containerID: 'toTop', // fading element id
	        containerHoverID: 'toTopHover', // fading element hover id
	        scrollSpeed: 1200,
	        easingType: 'linear' 
	        };
	        */

	        $().UItoTop({ easingType: 'easeOutQuart' });

	    });
	</script>
	<!-- //here ends scrolling icon -->
	<!-- start-smoth-scrolling -->

</body>
</html>
