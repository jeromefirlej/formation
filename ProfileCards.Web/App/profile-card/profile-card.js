(function (window, $) {
    const url = decodeURI(window.location.hash);
    var personId = url.split('#profiles/')[1].trim();
    $.getJSON("api/profiles/" + personId).done(function (profile) {
        let profileTemplate = $("#profile-template");
        $.tmpl(profileTemplate, profile,
            {
                getBackgroundImage: function() {
                    var backgroundImage = this.data.backgroundImage;
                    if (!backgroundImage) {
                        return this.data.profileImage;
                    }
                    return backgroundImage;
                }
            }).appendTo("#profile");
        $("#profile").addClass("visible");
    });
})(window, $);