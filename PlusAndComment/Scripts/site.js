﻿function showleaveComment(id, isAuth) {
    if (!isAuth) {
        alert("Nie jesteś zalogowany")
        return false;
    }

    var obj = $("#leaveCommentPartial_" + id);

    var display = obj.css("display");
    if (display != "none")
    {
        obj.attr("style", "display:none");
    }
    else
    {
        obj.attr("style", "display:block");
    }

    return false;
}

function OnAddCommentCoplete(id) {
    $("#wellLeaveComment_"+id).hide();
    return false;
}

function OnAddCommentFailure(params)
{
    var id = params.getResponseHeader("objectId")
    $('#leaveCommentContainer_' + id).html(params.responseText);
}

function showCommentsLoader(id)
{
    $("#loadingIndiComment_" + id).show();
    $("#buttonAllComments_" + id).hide();
}

function actionFailure(params)
{
    alert("Nie jesteś zalogowany");
}

function actionAddPlusSuccess(obj) {

    var target = $("#plusLabel" + obj.postId);
    target.html(obj.innerHtml);

    if (obj.isPlused)
    {
        target.css("background-color", "green");
    } else if (obj.isMinused)
    {
        target.css("background-color", "#2d383e");
    }
}

/*Index View*/
function NeedAgeChange(element) {
    $.ajax({
        url: '/Home/ChangeNeedAge',
        type: "Post",
        data: { id: element.id },
        success: function (result) {
            var id = result[0].Value;
            var val = $("#checkBoxNeedAge_" + id).prop("checked");

            if (val == true) {
                CoverAge(id);
            } else {
                UncoverAge(id);
            }
        }
    });
}

$(document).ready(function () {
    $('.gifplayer').gifplayer();
    $('[data-toggle="tooltip"]').tooltip();
    startCopy();
});

function CoverAge(id) {
    $("#coverForAge_" + id).show();
    $("#blurForAge_" + id).addClass("blur");

}

function UncoverAge(id) {
    $("#coverForAge_" + id).hide();
    $("#blurForAge_" + id).removeClass("blur");
}

function startCopy() {

  'use strict';

  // click events
  document.body.addEventListener('click', copy, true);

  // event handler
  function copy(e) {

    // find target element
    var
      t = e.target,
      c = t.dataset.copytarget,
      inp = (c ? document.querySelector(c) : null);

    // is element selectable?
    if (inp && inp.select) {
        // select text
          $("#"+inp.id).show();
          inp.select();
      try {
        // copy text
        document.execCommand('copy');
        inp.blur();
        $("#" + inp.id).hide();
      }
      catch (err) {
        alert('please press Ctrl/Cmd+C to copy');
      }
    }
  }
}

function DisableCommentButton(id, disable)
{
    $("#CommentButton_" + id).attr("disabled", disable);
}

function CopyLinkClicked(obj)
{
    $("#infoCopied").slideToggle(true);
    $('#infoCopied').delay(1500).slideToggle(false);
}

$(document).ready(function () {
    //var win = $(window);

    //// Each time the user scrolls
    //win.scroll(function () {
    //    // End of the document reached?
    //    if ($(document).height() - win.height() == win.scrollTop()) {
    //        $('#loading').show();
    //        var count = $(document).find('.row').length;

    //        $.ajax({
    //            url: '/Home/GetMoreMainPosts',
    //            type: "Post",
    //            dataType: 'json',
    //            traditional: true,
    //            data: { amount: count },
    //            success: function (obj) {
    //                var html = obj[0].Value;
    //                var id = obj[1].Value;

    //                $('#posts').append(html);
    //                $('#loading').hide();
    //                $('.gifplayer_' + id).gifplayer();
    //                $('[data-toggle="tooltip"]').tooltip();
    //            },
    //            failure: function () {
    //                $('#loading').hide();
    //            }
    //        });
    //    }
    //});
});