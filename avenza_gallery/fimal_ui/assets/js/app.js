const asinSearchBtn = document.querySelector(".asin-search-btn");
const searchForm = document.querySelector(".search-form");
const searchFormInput = document.querySelector(".search-form input");
const mirrorBackdrop = document.querySelector(".mirror-backdrop");
const accCta = document.querySelector(".account-cta");
const subNav = document.querySelector(".account-item .sub-nav");
const toggler = document.querySelector(".toggler");
const mobileNav = document.querySelector(".mobile-nav");
const backdrop = document.querySelector(".backdrop");
const backToTopCta = document.querySelector("#back-to-top");
const propSubTypes = document.querySelector(".prop-sub__types");
const propTypeTabs = document.querySelectorAll(".prop-type-tab");
const searchSubTypeInpt = document.querySelector("#search-prop-type");
const propTypeSelector = document.querySelector(".prop-type__selector");
const purposeTabItems = document.querySelectorAll(".purpose-tab");
const searchPropPurposeInpt = document.querySelector("#search-prop-purpose");
const header = document.querySelector("header");
const headerSection = document.querySelector(".header-section");
const mySwiperSlider = document.querySelector(".mySwiper");
const propSlider = document.querySelector(".propertySlider");
const propCtaCall = document.querySelectorAll(".prop-ctas__call");
const propCtaEmail = document.querySelectorAll(".prop-ctas__email");
const propEmailFormDiv = document.querySelector(".prop-ctas__form-div");
const closeCtasFormBtn = document.querySelector("#close-ctas__form-btn");
const propCtasSmsDiv = document.querySelector(".prop-ctas__sms-div");
const propCtasSmsBtn = document.querySelectorAll(".prop-ctas__sms");
const msgPropAsin = document.querySelector("#message-prop-asin");
const msgBodyPropAsin = document.querySelector("#message-message");
const propCtasSmsDivInpt = document.querySelector("#asin-to-share");
const propGalleryLink = document.querySelector('.prop-gallery img')
const propGalleryModal = document.querySelector('.prop-gallary__modal')
const galleryModalCloseBtn = document.querySelector('.gallery-modal__close-btn')

const propTypes = [
  { title: "House", type: "home" },
  { title: "Upper Portion", type: "home" },
  { title: "Farm House", type: "home" },
  { title: "Penthouse", type: "home" },
  { title: "Flat", type: "home" },
  { title: "Lower Portion", type: "home" },
  { title: "Room", type: "home" },
  { title: "Residential Plot", type: "plot" },
  { title: "Agricultural Land", type: "plot" },
  { title: "Plot File", type: "plot" },
  { title: "Commercial Plot", type: "plot" },
  { title: "Industrial Land", type: "plot" },
  { title: "Plot Form", type: "plot" },
  { title: "Office", type: "commercial" },
  { title: "Warehouse", type: "commercial" },
  { title: "Building", type: "commercial" },
  { title: "Shop", type: "commercial" },
  { title: "Factory", type: "commercial" },
  { title: "Other", type: "commercial" },
];
let propSubTypesElements;

propCtaCall ? propCtaCall.forEach(cta=>{
  cta.addEventListener("click", emailFormToggler);
}): null

propCtaEmail ? propCtaEmail.forEach(cta=>{
  cta.addEventListener("click", emailFormToggler);
}): null

function emailFormToggler() {
  const propAsin = this.parentElement.parentElement.parentElement.dataset.asin
  msgPropAsin.value = propAsin
  msgBodyPropAsin.textContent = 'I would like to inquire about your property at avenzaland.com with ASIN '+ propAsin +'. Please contact me at your earliest convenience'
  propEmailFormDiv.style.display = "block";
  backdrop.style.display = "block";
  setTimeout(() => {
    propEmailFormDiv.classList.add("email-div__active");
    backdrop.classList.add("visible-backdrop");
  }, 200);
}

propGalleryLink ? propGalleryLink.addEventListener('click', ()=>{
  propGalleryModal.style.display = 'flex';
}) : null

galleryModalCloseBtn ? galleryModalCloseBtn.addEventListener('click', ()=>{
  propGalleryModal.style.display = 'none';
}) : null

closeCtasFormBtn ? closeCtasFormBtn.addEventListener("click", () => {
  backdrop.classList.remove("visible-backdrop");
  propEmailFormDiv.classList.remove("email-div__active");
  setTimeout(() => {
    propEmailFormDiv.style.display = "none";
    backdrop.style.display = "none";
  }, 200);
}): null;
propCtasSmsBtn ? propCtasSmsBtn.forEach(btn=>{
  btn.addEventListener('click', ()=>{
    const propAsin = btn.parentElement.parentElement.parentElement.dataset.asin
    propCtasSmsDivInpt.value = propAsin
    propCtasSmsDiv.style.display = "block";
    backdrop.style.display = "block";
    setTimeout(() => {
    backdrop.classList.add("visible-backdrop");
    propCtasSmsDiv.classList.add("visible-sms-div");
  }, 150);
  })
}): null

if (mySwiperSlider) {
  let swiper = new Swiper(".mySwiper", {
    slidesPerView: 4,
    spaceBetween: 10,
    loop: true,
    pagination: {
      el: ".swiper-pagination",
      clickable: true,
      dynamicBullets: true,
    },
    autoplay: {
      delay: 2500,
      disableOnInteraction: false,
    },
    breakpoints: {
      320: {
        slidesPerView: 1,
        spaceBetween: 20,
      },
      768: {
        slidesPerView: 3,
        spaceBetween: 20,
      },
      1024: {
        slidesPerView: 4,
        spaceBetween: 10,
      },
      1440: {
        slidesPerView: 5,
        spaceBetween: 20,
      },
    },
  });
}
if (propSlider) {
  let swiper = new Swiper(".propertySlider", {
    slidesPerView: 1,
    spaceBetween: 10,
    loop: true,
    pagination: {
      el: ".swiper-pagination",
      clickable: true,
      dynamicBullets: true,
    },
    autoplay: {
      delay: 2500,
      disableOnInteraction: false,
    },
  });
}

document.addEventListener("DOMContentLoaded", () => {
  displayPropType("home");
});
if (purposeTabItems) {
  purposeTabItems.forEach((tabItem) => {
    tabItem.addEventListener("click", () => {
      purposeTabItems.forEach((item) => {
        item.classList.remove("active");
      });
      tabItem.classList.add("active");
      if (tabItem.classList.contains("buy-tab")) {
        searchPropPurposeInpt.value = "Buy";
      } else if (tabItem.classList.contains("rent-tab")) {
        searchPropPurposeInpt.value = "Rent";
      }
    });
  });
}
if (searchSubTypeInpt) {
  searchSubTypeInpt.addEventListener("click", () => {
    backdrop.style.display = "block";
    propTypeSelector.style.display = "block";
    setTimeout(() => {
      backdrop.classList.add("visible-backdrop");
      propTypeSelector.classList.add("show-selector");
    }, 150);
  });
}

function displayPropType(filter) {
  if (propSubTypes) {
    propSubTypes.innerHTML = "";
    propTypes.forEach((propType) => {
      if (propType.type == filter) {
        let item = document.createElement("li");
        item.classList.add("prop-sub__type");
        item.textContent = propType.title;
        propSubTypes.appendChild(item);
      }
    });
  }
  propSubTypesElements = document.querySelectorAll(".prop-sub__type");
  propSubTypesElements.forEach((subTypeEl) => {
    subTypeEl ? subTypeEl.addEventListener("click", () => {
      propSubTypesElements.forEach((item) => {
        item.classList.remove("active");
      });
      searchSubTypeInpt.value = subTypeEl.textContent;
      subTypeEl ? subTypeEl.classList.add("active"):null;
      backdrop.classList.remove("visible-backdrop");
      propTypeSelector ? propTypeSelector.classList.remove("show-selector"):null;
      setTimeout(() => {
        backdrop.style.display = "none";
        propTypeSelector ? propTypeSelector.style.display = "none":null
      }, 150);
    }):null;
  });
}
if (propTypeTabs) {
  propTypeTabs.forEach((typeTab) => {
    typeTab.addEventListener("click", (e) => {
      e.preventDefault();
      propTypeTabs.forEach((item) => {
        item.classList.remove("active");
      });
      typeTab.classList.add("active");
      if (typeTab.classList.contains("prop-type-home")) {
        displayPropType("home");
      } else if (typeTab.classList.contains("prop-type-plot")) {
        displayPropType("plot");
      } else {
        displayPropType("commercial");
      }
    });
  });
}

backToTopCta.addEventListener("click", () => {
  window.scrollTo({
    top: 0,
    behavior: "smooth",
  });
});
if (toggler) {
  toggler.addEventListener("click", () => {
    mobileNav.style.display = "block";
    backdrop.style.display = "block";
    setTimeout(() => {
      mobileNav.classList.add("mobile-nav__active");
      mobileNav.classList.add("visible-backdrop");
      backdrop.classList.add("visible-backdrop");
    }, 150);
  });
}
if (backdrop) {
  backdrop.addEventListener("click", () => {
    mobileNav ? mobileNav.classList.remove("mobile-nav__active"): null;
    mobileNav ? mobileNav.classList.remove("visible-backdrop"): null;
    backdrop.classList.remove("visible-backdrop");
    propTypeSelector ? propTypeSelector.classList.remove("show-selector"): null;
    propEmailFormDiv ? propEmailFormDiv.classList.remove("email-div__active"): null;
    propCtasSmsDiv ? propCtasSmsDiv.classList.remove("visible-sms-div"): null;
    setTimeout(() => {
      propEmailFormDiv ? propEmailFormDiv.style.display = "none": null;
      propTypeSelector ? propTypeSelector.style.display = "none": null;
      mobileNav ? mobileNav.style.display = "none": null;
      propCtasSmsDiv ? propCtasSmsDiv.style.display = "none": null;
      backdrop.style.display = "none";
    }, 150);
  });
}
if (accCta) {
  accCta.addEventListener("click", () => {
    if (!accCta.classList.contains("active")) {
      accCta.classList.add("active");
      mirrorBackdrop.style.display = "block";
      subNav.style.display = "block";
      searchForm.style.display = "none";
      setTimeout(() => {
        searchForm.classList.remove("visible-search-form");
        subNav.classList.add("visible-backdrop");
        mirrorBackdrop.classList.add("visible-backdrop");
      }, 100);
    } else {
      accCta.classList.remove("active");
      subNav.classList.remove("visible-backdrop");
      mirrorBackdrop.classList.remove("visible-backdrop");
      setTimeout(() => {
        subNav.style.display = "none";
        mirrorBackdrop.style.display = "none";
      }, 100);
    }
  });
}

if (asinSearchBtn) {
  asinSearchBtn.addEventListener("click", () => {
    searchFormInput.value = "";
    searchForm.style.display = "block";
    mirrorBackdrop.style.display = "block";
    subNav.style.display = "none";
    setTimeout(() => {
      subNav.classList.remove("visible-backdrop");
      mirrorBackdrop.classList.add("visible-backdrop");
      searchForm.classList.add("visible-search-form");
    }, 150);
  });
}
if (mirrorBackdrop) {
  mirrorBackdrop.addEventListener("click", () => {
    subNav.classList.remove("visible-backdrop");
    mirrorBackdrop.classList.remove("visible-backdrop");
    searchForm.classList.remove("visible-search-form");
    setTimeout(() => {
      searchForm.style.display = "none";
      mirrorBackdrop.style.display = "none";
      subNav.style.display = "none";
      accCta.classList.remove("active");
    }, 150);
  });
}

// window.addEventListener("scroll", () => {
//   if (
//     window.scrollY >= window.innerHeight / 4 ||
//     window.pageYOffset >= window.innerHeight / 4
//   ) {
//     header.style.background = "white";
//     header.style.color = "black";
//   } else {
//     header.style.background = "none";
//     header.style.color = "white";
//   }
// });

// function isScrolledIntoView(el) {
//   let rect = el.getBoundingClientRect();
//   let elemTop = rect.top;
//   let elemBottom = rect.bottom;
//   let isVisible = elemTop < window.innerHeight && elemBottom >= 0;
//   return isVisible;
// }