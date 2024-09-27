# Prism Navigation Padding iOS Repro

Reproduction of content page padding issue on iOS when using PrismNavigationPage. When displaying a modal page with a navigation page, the content of the root page gets pushed slightly down the page, a top padding of -8px will workaround the issue.

## How To Run

Originally I believe this was a weird issue with prism since I wasn't able to reproduce without prism. In this repo I managed to reproduce the issue without prism so there are 2 apps in this project, they are the same app but one is written in prism and the other is vanilla maui..

- Open solution
- Run either app (`PrismApp`/`VanillaApp`)
- Open modal (but pressing button)
- Observe a gap between the status bar yelow & the content view green
- Uncomment the padding, observe issue is "fixed"