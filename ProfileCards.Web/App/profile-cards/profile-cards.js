(function(window, $) {
    const carousel = $("#carouselExample");

    $.getJSON("app/profile-cards/profiles.json").done(function (profiles) {
        $('<div></div>').load(
            "/app/profile-cards/profile-cards-item.html",
            function (template) {
                $.template("profile-cards-item-template", template);
                $.tmpl("profile-cards-item-template",
                    profiles,
                    {
                        getBackgroundImage: function() {
                            var backgroundImage = this.data.backgroundImage;
                            if (!backgroundImage) {
                                return this.data.profileImage;
                            }
                            return backgroundImage;
                        },
                        gotoProfile: function() {
                            console.log("plop");
                        }
                    }).each(function(index) {
                    $(this).bind("click",
                        function() {
                            window.location.hash = "#profiles/" + index;
                        });
                }).appendTo(".carousel-inner");
                
                $(".carousel-inner").children().first().addClass("active");

                carousel.addClass("visible");
                carousel.on("slide.bs.carousel",
                    function(e) {
                        const relatedTarget = $(e.relatedTarget);
                        const indexOfTarget = relatedTarget.index();
                        const itemsPerSlide = 4;
                        const carouselItem = $(".carousel-item");
                        const totalItems = carouselItem.length;

                        if (indexOfTarget >= totalItems - (itemsPerSlide - 1)) {
                            const it = itemsPerSlide - (totalItems - indexOfTarget);
                            for (let i = 0; i < it; i++) {
                                // append slides to end
                                if (e.direction == "left") {
                                    carouselItem.eq(i).appendTo(".carousel-inner");
                                } else {
                                    carouselItem.eq(0).appendTo(".carousel-inner");
                                }
                            }
                        }
                    });

                carousel.carousel({
                        interval: 2000
                    });

            });
    });
})(window, $);