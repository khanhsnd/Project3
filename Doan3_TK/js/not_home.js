(function($){        
         // Content
        $("#ud .h3ud").prepend("<span class='icon-task'></span>");               
        $("#th .h3th").prepend("<span class='icon-setting'></span>");               
        $("#ha .h3th").prepend("<span class='icon-camera'></span>");               
        $("#tgcp .tgcp").prepend("<span class='icon-time'></span>");      
        
        // Xy ly p rong va trong p co <br> Gay khoang cach ND
        $( ".entry-content p" ).each(function( index ) {
          if($( this ).html() == '' || $( this ).html() == '<br>' || $( this ).html() == ' ' || $( this ).html() == '  ' || $( this ).html() == '   ' || $( this ).html() == '&nbsp;'){            
                $( this ).remove();            
          }
        });       
        
        // Scroll Menu always to top
        var menu = $('#top_hotline'),
		pos = menu.offset();		
		$(window).scroll(function(){
			if($(this).scrollTop() > pos.top+menu.height() && menu.hasClass('default')){
				menu.fadeOut('fast', function(){
					$(this).removeClass('default').addClass('fixed').fadeIn('fast');
				});
			} else if($(this).scrollTop() <= pos.top && menu.hasClass('fixed')){
				menu.fadeOut('fast', function(){
					$(this).removeClass('fixed').addClass('default').fadeIn('fast');
				});
			}
		});     
        
        // Xy Ly tab comment
        $(document).ready(function(){
          $("#tab_1").click(function(){
            $(this).addClass('cm-act');
            $("#tab_2").removeClass('cm-act');
            $('.facebook-commment').hide();
            $('.comment_default').show();
          });
          
          $("#tab_2").click(function(){
            $(this).addClass('cm-act');
            $("#tab_1").removeClass('cm-act');
            $('.facebook-commment').show();
            $('.comment_default').hide();
          });
        });
		
		
             
})( jQuery );