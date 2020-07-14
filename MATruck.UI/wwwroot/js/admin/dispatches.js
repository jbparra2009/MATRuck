app = new Vue({
    el: '#app',
    data: {
        editing: false,
        loading: false,
        objectIndex: 0,
        dispatchModel: {
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
            corpName: "",
            ein: "",
            created: "",
            status: ""
        },
        dispatches: []
    },
    mounted() {
        this.getDispatches();
    },
    methods: {
        getDispatch(id) {
            this.loading = true;
            axios.get('/Admin/dispatches/' + id)
                .then(res => {
                    console.log(res);
                    var dispatch = res.data;
                    this.dispatchModel = {
                        id: 0,
                        firstName: dispatch.firstName,
                        lastName: dispatch.lastName,
                        description: dispatch.description,
                        email: dispatch.email,
                        phone1: dispatch.phone1,
                        phone2: dispatch.phone2,
                        rate: dispatch.rate,
                        address1: dispatch.address1,
                        address2: dispatch.address2,
                        city: dispatch.city,
                        state: dispatch.state,
                        zipCode: dispatch.zipCode,
                        ss: dispatch.ss,
                        corpName: dispatch.corpName,
                        ein: dispatch.ein,
                        created: dispatch.created,
                        status: dispatch.status
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        getDispatches() {
            this.loading = true;
            axios.get('/Admin/dispatches')
                .then(res => {
                    console.log(res);
                    this.dispatches = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createDispatch() {
            this.loading = true;
            axios.post('/Admin/dispatches', this.dispatchModel)
                .then(res => {
                    console.log(res.data);
                    this.dispatches.push(res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateDispatch() {
            this.loading = true;
            axios.put('/Admin/dispatches', this.dispatchModel)
                .then(res => {
                    console.log(res.data);
                    this.dispatches.splice(this.objectIndex, 1, res.data);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        deleteDispatch(id, index) {
            this.loading = true;
            axios.delete('/Admin/dispatches/' + id)
                .then(res => {
                    console.log(res);
                    this.dispatches.splice(index, 1);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newDispatch() {
            this.editing = true;
            this.dispatchModel.id = 0;
        },
        editDispatch(id, index) {
            this.objectIndex = index;
            this.getDispatch(id);
            this.editing = true;
        },
        cancel() {
            this.editing = false;
        }
    },
    computed: {
    }
});