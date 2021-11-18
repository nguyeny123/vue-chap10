<template>
<!-- <div class="products">
<h1>Products</h1>
    <div class="list">
        <div class="item" v-for="product in products" :key="product.slug">
            <h3 @click="select(product)">{{ product.name }}</h3>
            <img :src="product.thumbnail" :alt="product.name"
            @click="select(product)" />
            <p @click="select(product)">{{ product.shortDescription }}
            </p>
            <p @click="select(product)">{{ product.price }}</p>
            <hr />
        </div>
    </div>

</div> -->
<div class="products">
<!-- <b-container>
<h1 class="mt-4 mb-4">Products</h1> -->
<b-row>
<b-col class="mb-4" sm="6" v-for="product in products"
:key="product.id">
<b-media class="product">
<img slot="aside" :src="product.thumbnail"
:alt="product.name" @click="view(product)"  class="pr-2" />
<h2 class="mt-2" @click="view(product)">{{ product.name }}
</h2>
<p class="mt-4 mb-4">
{{ product.shortDescription }}
</p>
<p class="mt-4 mb-4">Prices from £{{ product.price }}</p>
<!-- <b-button variant="primary">Add to cart</b-button> -->
</b-media>
</b-col>
</b-row>
<!-- </b-container> -->
</div>
</template>
<script>
// import ProductDetails from './Details.vue'
export default {
name: "product-list",
// components: {
// ProductDetails
// },
props: {
products: {
type: Array,
required: true
}
},
    methods: {
        view(product) {
        this.$router.push(`/products/${product.slug}`);
        }
    }
};
</script>

<style lang="scss" scoped>
.product {
border: 3px solid #eee;
img,
h2 {
cursor: pointer;
}
}
</style>