const $ = document.querySelector.bind(document);
const $$ = document.querySelectorAll.bind(document);

const tabs = $$(".product-detail-list-img");
const panes = $$(".product-detail-img-main");
const choose = $$(".choose-product-img");




tabs.forEach((tab, index) => {
    const pane = panes[index];
    const choo = choose[index];

    tab.onclick = function () {
        $(".product-detail-list-img.active").classList.remove("active");
        $(".product-detail-img-main.active").classList.remove("active");
        $(".choose-product-img.active").classList.remove("active");



        this.classList.add("active");
        pane.classList.add("active");
        choo.classList.add("active");
    };
});





choose.forEach((tab, index) => {
    const pane = panes[index];
    const imglist = tabs[index];

    tab.onclick = function () {
        $(".choose-product-img.active").classList.remove("active");
        $(".product-detail-img-main.active").classList.remove("active");
        $(".product-detail-list-img.active").classList.remove("active");



        this.classList.add("active");
        pane.classList.add("active");
        imglist.classList.add("active");
    };
});