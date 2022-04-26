<template>
    <section>
        <h2>Overview of all things in the troop</h2>
        <mission-list></mission-list>
    </section>
</template>

<script>
import MissionList from "../components/Missions/MissionList.vue"

export default {
    components: {
        MissionList
    }
}
</script>