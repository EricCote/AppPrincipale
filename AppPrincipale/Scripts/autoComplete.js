$(function () {
    $("#txtRecherche").autocomplete({
        source: "/produit/suggestion",
        minLength: 1
    });
});
