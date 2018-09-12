(function (window, $) {
    const url = decodeURI(window.location.hash);
    var index = url.split('#profiles/')[1].trim();
    $.getJSON("app/profile-cards/profiles.json").done(function (profiles) {
        let profileTemplate = $("#profile-template");
        $.tmpl(profileTemplate, profiles[index],
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