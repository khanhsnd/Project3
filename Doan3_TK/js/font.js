	$(document).ready(function(){
		if(document.getElementById("boxsearch"))
		{
			$(window).scroll(function(){
				var scrollTop= $(window).scrollTop();
				if(scrollTop >125){
					$("#boxsearch").addClass("fixed");
				}else{
					$("#boxsearch").removeClass("fixed");
				}
			});
		}
		if(document.getElementById("header_fixed"))
		{
			$(window).scroll(function(){
				var scrollTop= $(window).scrollTop();
				if(scrollTop >55){
					$("#header_fixed").addClass("fixed");
				}else{
					$("#header_fixed").removeClass("fixed");
				}
			});
		}

		$("#search_show").click(function(){
			$("#boxsearch2").toggle();
		})
		$(".listpage a.circle").click(function(){
			var _val = $(this).text();
			$(".listpage a.circle").removeClass("active")
			$(this).addClass("active");
			$("#wtintuc ul li").hide();
			$("#wtintuc ul li." + _val).fadeIn("slow");
		})
		if(document.getElementById("bxlider_gallery"))
		{
			$('#bxlider_gallery').bxSlider({
			  pagerCustom: '#bx_pager'
			});
		}
		if(document.getElementById("crsl_wrap"))
		{
			$('#crsl_wrap').bxSlider({
			  auto: true,	
			  minSlides: 4,
			  maxSlides: 4,
			  slideWidth: 179,
			  slideMargin: 10
			});
			
			$("#navbtns .previous").click(function(){
				$(".project_others_slider .bx-prev").click();
			}) 
			$("#navbtns .next").click(function(){
				$(".project_others_slider .bx-next").click();
			}) 
		}
		if(document.getElementById("bxslider_banner"))
		{
			$('#bxslider_banner').bxSlider({
				  auto: true,	
				  minSlides: 1,
				  maxSlides: 1,
			});
			
			$(".box-banner .box-banner-prev").click(function(){
				$(".box-banner .bx-prev").click();
			}) 
			$(".box-banner .box-banner-next").click(function(){
				$(".box-banner .bx-next").click();
			}) 
		}
		
		
	})
