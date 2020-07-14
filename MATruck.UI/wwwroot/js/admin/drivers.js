app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        driverModel: {
            id: 0,
            firstName: "",
            lastName: "",
            description: "",
            email: "",
            phone1: "",
            phone2: "",
            rate: "",
            address1: "",
            address2: "",
            city: "",
            state: "",
            zipCode: "",
            ss: "",
            dob: "",
            cdlClass: "",
            cdlIssued: "",
            cdlExpires: "",
            cdlState: "",
            corpName: "",
            ein: "",
            created: "",
            status: ""
        },
        drivers: []
    },
    mounted() {
        this.getDrivers();
    },
    methods: {
        getDriver(id) {
            this.loading = true;
            axios.get('/Admin/drivers/' + id)
                .then(res => {
                    console.log(res);
                    var driver = res.data;
                    this.driverModel = {
                        id: driver.id,
                        firstName: driver.firstName,
                        lastName: driver.lastName,
                        description: driver.description,
                        email: driver.email,
                        phone1: driver.phone1,
                        phone2: driver.phone2,
                        rate: driver.rate,
                        address1: driver.address1,
                        address2: driver.address2,
                        city: driver.city,
                        state: driver.state,
                        zipCode: driver.zipCode,
                        ss: driver.ss,
                        dob: driver.dob,
                        cdlClass: driver.cdlClass,
                        cdlIssued: driver.cdlIssued,
                        cdlExpires: driver.cdlExpires,
                        cdlState: driver.cdlState,
                        corpName: driver.corpName,
                        ein: driver.ein,
                        created: driver.created,
                        status: driver.status
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getDrivers() {
            this.loading = true;
            axios.get('/Admin/drivers')
                .then(res => {
                    console.log(res);
                    this.drivers = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createDriver() {
            this.loading = true;
            axios.post('/Admin/drivers', this.driverModel)
                .then(res => {
                    console.log(res.data);
                    this.drivers.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateDriver() {
            this.loading = true;
            axios.put('/Admin/drivers', this.driverModel)
                .then(res => {
                    console.log(res.data);
                    this.drivers.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteDriver(id, index) {
            this.loading = true;
            axios.delete('/Admin/drivers/' + id)
                .then(res => {
                    console.log(res);
                    this.drivers.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newDriver() {
            this.editing = true;
            this.driverModel.id = 0;
        },
        editDriver(id, index) {
            this.objectIndex = index;
            this.getDriver(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});