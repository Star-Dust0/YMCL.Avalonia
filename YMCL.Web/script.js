// Smooth scroll for navigation links
document.querySelectorAll('a[href^="#"]').forEach((anchor) => {
  anchor.addEventListener("click", function (e) {
    const href = this.getAttribute("href");
    if (href !== "#" && document.querySelector(href)) {
      e.preventDefault();
      document.querySelector(href).scrollIntoView({
        behavior: "smooth",
      });
    }
  });
});

// Fetch GitHub stats
async function fetchGitHubStats() {
  try {
    const response = await fetch(
      "https://api.github.com/repos/yiikooo/YMCL.Avalonia"
    );
    const data = await response.json();

    // Update downloads (using watchers as a proxy, since GitHub API doesn't provide direct download count)
    const downloadsElement = document.getElementById("downloads");
    if (downloadsElement && data.watchers_count) {
      downloadsElement.textContent = data.watchers_count.toLocaleString();
    }

    // Update stars
    const starsElement = document.getElementById("stars");
    if (starsElement && data.stargazers_count) {
      starsElement.textContent = data.stargazers_count.toLocaleString();
    }
  } catch (error) {
    console.log("Could not fetch GitHub stats:", error);
    // Set default values if fetch fails
    document.getElementById("downloads").textContent = "1000+";
    document.getElementById("stars").textContent = "500+";
  }
}

// Call on page load
document.addEventListener("DOMContentLoaded", fetchGitHubStats);

// Add scroll animation for elements
const observerOptions = {
  threshold: 0.1,
  rootMargin: "0px 0px -100px 0px",
};

const observer = new IntersectionObserver(function (entries) {
  entries.forEach((entry) => {
    if (entry.isIntersecting) {
      entry.target.style.opacity = "1";
      entry.target.style.transform = "translateY(0)";
    }
  });
}, observerOptions);

// Observe feature cards and download cards
document.querySelectorAll(".feature-card, .download-card").forEach((el) => {
  el.style.opacity = "0";
  el.style.transform = "translateY(20px)";
  el.style.transition = "opacity 0.6s ease, transform 0.6s ease";
  observer.observe(el);
});

// Add active state to navbar on scroll
window.addEventListener("scroll", () => {
  const navbar = document.querySelector(".navbar");
  if (window.scrollY > 50) {
    navbar.style.boxShadow = "0 4px 12px rgba(0, 0, 0, 0.1)";
  } else {
    navbar.style.boxShadow = "0 2px 8px rgba(0, 0, 0, 0.08)";
  }
});

// Mobile menu toggle (if needed in future)
function toggleMobileMenu() {
  const navLinks = document.querySelector(".nav-links");
  navLinks.classList.toggle("active");
}
