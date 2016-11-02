export function configure(aurelia) {
    aurelia.use
        .standardConfiguration()
        .developementLogging();
    aurelia.start().then(a => a.setRoot());
}