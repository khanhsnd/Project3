(function($){
    // Set date time picker
    // $('.datepicker').datepicker({ dateFormat: 'yy-mm-dd' });
    $("#send_mail_v1 .btn-submit").click(function(){
        if($("#send_mail_v1 #username").val() != '' && $("#send_mail_v1 #phone").val() != ''  && $("#send_mail_v1 #email").val() != ''  && $("#send_mail_v1 #message").val() != ''){
            $(this).prop('disabled', true);
            $('#send_mail_v1 .message-error').html('');
            // Get value 
            name = $("#send_mail_v1 #username").val();
            phone = $("#send_mail_v1 #phone").val();
            email = $("#send_mail_v1 #email").val();
            link = $("#send_mail_v1 #link").val();
            //time = $("#time").val();
            message = $("#send_mail_v1 #message").val();
            // Validate input
            if(!IsEmail(email)){
                $('#send_mail_v1 .message-error').html('Email bạn nhập không đúng.');
                $(this).prop('disabled', false);
            }else{ 
                $('#send_mail_v1 .message-error').html(''); 
                // Show icon loading
                $('#send_mail_v1 .loading').show();
                // Call ajax to send mail
                var url = 'http://'+window.location.host+'/wp-content/themes/phuxuan_v2/include/contact-mail-single/inc/send_mail.php?name='+name+'&phone='+phone+'&email='+email+'&link='+link+'&message='+message; // the script where you handle the form input.
                $.ajax({
                       delay: 0,
          		       url: url,
              		   type: 'GET',
              		   dataType: 'text',
                       success: function(data)
                       {
                           if(data.trim() == 'sendmail-success'){
                                $(this).prop('disabled', false);
                                $('#send_mail_v1 .loading').hide();
                                $('#send_mail_v1 .notification').show();
                           }
                       }
                     });
                return false; // avoid to execute the actual submit of the form.
            }
        }else{
            $('#send_mail_v1 .message-error').html('Bạn hãy nhập đầy đủ thông tin!');
            return false;
        }
    });
    
    // Click button DK
     $(document).ready(function(){
        $('.show-form-sendmail').click(clickFormSendMail);
        $('.dk a').click(clickFormSendMail);
        
        function clickFormSendMail(){
            if(!$('body').hasClass('single')){
                $('#send_mail_v1').show();
            }else{
                $('#send_mail_v1').addClass('fix_position');
                $('#send_mail_v1').show();               
            }             
            $('.btn-close').show();           
            $('.overlay').css('visibility','visible');
            return false;
        }
        
        $('.btn-close').click(function(){
            if(!$('body').hasClass('single')){
                $('#send_mail_v1').hide();                
            }else{
                $('#send_mail_v1').removeClass('fix_position');
            }
            $(this).hide();
            $('.overlay').css('visibility','hidden');
            return false;
        });
    });  
})( jQuery );
function IsEmail(email) {
  var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
  return regex.test(email);
}