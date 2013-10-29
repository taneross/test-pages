//prototype js
//by Tane, Oct 2013


function initOutline() {
  $( "#sortable-mater" ).sortable();
  $( "#sortable-master" ).disableSelection();
  $( "#sortable-outline" ).sortable();
  $( "#sortable-outline" ).disableSelection();
  
  $("#sortable-master li button").click(function() {
		  console.log("clicked: "+$(this).attr('id'));
		  addChild(this)
    	  
  });
  /*
	function addChild(wasClicked){
		var $wasClicked = $(wasClicked);
		var $liClicked = $( wasClicked ).parent();
		var $parentTag = $ ($liClicked).parent();
		var $count = $( $parentTag).children().length;
		console.log( "addChild[]  " + $wasClicked.prop('id') + "   " + $wasClicked.prop('class') + "  _parent: " + $parentTag.prop('class') +" " + $count);
	
		var selection_bar = $( "#rung1" ).html();
		$liClicked.replaceWith(  selection_bar );
		
		console.log( selection_bar )
		
		// ui-state-default bar-section
	}

*/




  
};