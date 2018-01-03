<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="banner.ascx.cs" Inherits="Doan3_TK.control.banner" %>
<script src="js/jquery.bxslider.min.js"></script>
<style>
    .slider-big-top .bx-controls.bx-has-controls-direction {
        bottom: 30px;
        height: 38px;
        position: absolute;
        width: 100%;
    }

        .slider-big-top .bx-controls.bx-has-controls-direction .bx-prev {
            background: url("../images/a10.png") no-repeat scroll -11px -41px rgba(0, 0, 0, 0);
            cursor: pointer;
            display: block;
            height: 38px;
            left: 0;
            overflow: hidden;
            position: absolute;
            text-indent: -1000px;
            width: 37px;
        }

        .slider-big-top .bx-controls.bx-has-controls-direction .bx-next {
            background: url("../images/a10.png") no-repeat scroll -71px -41px rgba(0, 0, 0, 0);
            cursor: pointer;
            display: block;
            height: 38px;
            overflow: hidden;
            position: absolute;
            right: 0;
            text-indent: -1000px;
            width: 37px;
        }

    #project_others_slider .item {
        float: left;
        padding-bottom: 15px;
    }

    .project_others_slider .bx-controls {
        display: none;
    }

    .box-banner {
        height: 378px;
        overflow: hidden;
        position: relative;
        width: 100%;
        margin: 0px auto;
    }

        .box-banner ul.bxslider-banner {
            float: left;
            height: 378px;
            width: 100%;
            margin: 0px;
            padding: 0px;
        }

            .box-banner ul.bxslider-banner li {
                float: left;
                height: 378px;
                width: 100%;
            }

                .box-banner ul.bxslider-banner li img {
                    height: 378px;
                    width: 100%;
                }

        .box-banner .bx-wrapper .bx-pager {
            bottom: 15px;
            position: absolute;
            right: 10px;
            text-align: center;
            width: 100%;
            z-index: 100;
        }

        .box-banner .bx-wrapper .bx-pager-item {
            display: inline-block;
        }

        .box-banner .bx-wrapper a.bx-pager-link {
            background: url(../images/b05.png);
            display: inline-block;
            margin-left: 5px;
            text-indent: -999999px;
            background-position: -7px -7px;
            height: 16px;
            width: 16px;
        }

            .box-banner .bx-wrapper a.bx-pager-link:hover, .box-banner .bx-wrapper a.active {
                background-position: -67px -7px;
            }

    .box-banner-prev {
        height: 46px;
        left: 0;
        top: 153px;
        width: 30px;
        background: url("./images/a12.png") no-repeat scroll -16px -37px rgba(0, 0, 0, 0);
        position: absolute;
        z-index: 99;
    }

    .box-banner-next {
        height: 46px;
        right: 0;
        top: 153px;
        width: 30px;
        background: url("./images/a12.png") no-repeat scroll -75px -37px rgba(0, 0, 0, 0);
        position: absolute;
        z-index: 99;
    }

    .wrap-box-banner {
        width: 100%;
        padding: 0px 0px;
        margin-bottom: 10px;
    }
    /*.wrap-box-banner{background:#237ccc;width:100%;padding:10px 0px;margin-bottom:10px;}*/
</style>
<div class="slideshow-homepage">


    <div class="wrap-box-banner">
        <div class="box-banner">
            <a class="box-banner-prev"></a><a class="box-banner-next"></a>
            <ul class="bxslider-banner" id="bxslider_banner">
                <asp:Repeater ID="rptbanner" runat="server">
                    <ItemTemplate>
                        <li><a href="<%# Eval("link").ToString() %>">
                            <img src="<%# Eval("HinhAnh").ToString() %>" class="ls-bg" alt="Slide background" style="width: 100%;">
                        </a></li>
                    </ItemTemplate>
                </asp:Repeater>


            </ul>
        </div>
    </div>
</div>
