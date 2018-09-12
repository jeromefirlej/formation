(function (window, $) {
    $(window).on('hashchange', function () {
        // On every hash change the render function is called with the new hash.
        // This is how the navigation of our app happens.
        render(decodeURI(window.location.hash));
    });

    let content = $('.container.body-content');

    function render(url) {
        // Get the keyword from the url.
        var urlParam = url.split('/')[0];

        // Hide whatever page is currently shown.
        $('.body-content.page').removeClass('visible');

        const routes = {

                // The "Homepage".
                '': function() {
                    content.load('/app/profile-cards/profile-cards.html');
                },

                // Single Products page.
                '#profiles': function() {
                    // Get the index of which product we want to show and call the appropriate function.
                    content.load('/app/profile-card/profile-card.html');
                }
            };

        routes[urlParam]();
    }

    render(decodeURI(window.location.hash), arguments);
    window.profilesCard = {
            render: render
    };
})(window, $);