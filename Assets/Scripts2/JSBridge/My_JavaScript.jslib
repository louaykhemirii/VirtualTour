mergeInto(LibraryManager.library, {

	ShowMessage: function () {

		window.alert('Louay Set');
		localStorage.setItem('firstname', 'Louay'); 
    var getJson = localStorage.getItem('firstname');
    window.alert(getJson);
	},  

});